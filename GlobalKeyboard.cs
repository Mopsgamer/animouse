using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;
using static mouseutil.Program;

namespace GlobalInput
{
    public class GlobalKeyEventArgs : EventArgs
    {
        public Key Key;
        public bool IsDown;
        public GlobalKeyEventArgs(Key key, bool isDown)
        {
            Key = key;
            IsDown = isDown;
        }
    }

    public class GlobalShortcut
    {
        public readonly Key[] KeyArray;

        public GlobalShortcut(Key[] keys)
        {
            KeyArray = keys;
        }
        public GlobalShortcut(Key key)
        {
            KeyArray = new Key[] { key };
        }
        public GlobalShortcut(string str)
        {
            var valid = TryParse(str, out GlobalShortcut newThis);
            KeyArray = newThis.KeyArray;
            if (!valid)
            {
                string message =
                    "Invalid shortcut: '" + str + "'." +
                    "Available keys: " + string.Join(", ", KeyboardKeys);
                throw new Exception(message);
            }
        }

        private readonly static string Separator = "+";
        public static string[] KeyboardKeys = Array.ConvertAll(Enum.GetValues(typeof(Keys)).Cast<Keys>().ToArray(), i => i.ToString());

        static public bool TryParse(string str, out GlobalShortcut shortcut)
        {
            var keys = new List<Key> { };
            var valid = Array.TrueForAll(str.Split(new string[] { Separator }, StringSplitOptions.None), s =>
            {
                var validKey = Enum.TryParse(s, out Key key);
                if (validKey)
                {
                    keys.Add(key);
                }
                return validKey;
            });
            shortcut = null;
            if (valid)
            {
                shortcut = new GlobalShortcut(keys.ToArray());
            }
            return valid;
        }

        public override string ToString()
        {
            return string.Join(Separator, Array.ConvertAll(KeyArray, k => k.ToString()));
        }

        public string ToReadableString()
        {
            return GlobalKeyboard.ToReadableString(KeyArray);
        }

        public bool Equals(GlobalShortcut shortcut)
        {
            return shortcut.ToString() == ToString();
        }

        public bool Equals(string shortcut)
        {
            return shortcut == ToString();
        }

        public bool IsDown()
        {
            return GlobalKeyboard.IsDown(KeyArray);
        }
    }

    public static class GlobalKeyboard
    {
        private static LowLevelKeyboardProc hhkDelegate;
        private static IntPtr hhk = IntPtr.Zero;
        private static int nCode;
        private static IntPtr wParam;
        private static IntPtr lParam;
        private static readonly Dictionary<Key, bool> map = new Dictionary<Key, bool>();
        private static readonly List<string> specialKeys = new List<string> { "Ctrl", "Alt", "Shift" };
        public static GlobalShortcut lastShortcut;
        public static Key lastKeyDown;
        public static Key lastKeyUp;
        public static event EventHandler<GlobalKeyEventArgs> OnKeyDown;
        public static event EventHandler<GlobalKeyEventArgs> OnKeyUp;
        public static event EventHandler<GlobalKeyEventArgs> OnKey;

        public static void Listen()
        {
            Process curProcess = Process.GetCurrentProcess();
            ProcessModule curModule = curProcess.MainModule;
            hhkDelegate = new LowLevelKeyboardProc(HookCallback);
            hhk = SetWindowsHookEx(13, hhkDelegate, GetModuleHandle(curModule.ModuleName), 0);
        }

        public static void Dispose()
        {
            UnhookWindowsHookEx(hhk);
        }

        public static void Call(Key key, bool isDown)
        {
            map[key] = isDown;

            if (isDown)
            {
                lastKeyDown = key;

                lastShortcut = new GlobalShortcut(
                    map
                        .Where(p => IsDown(p.Key))
                        .Select(p => p.Key)
                        .ToArray()
                    );

                OnKeyDown?.Invoke(null, new GlobalKeyEventArgs(key, isDown));
            }
            else
            {
                lastKeyUp = key;

                OnKeyUp?.Invoke(null, new GlobalKeyEventArgs(key, isDown));
            }
            OnKey?.Invoke(null, new GlobalKeyEventArgs(key, isDown));
        }

        public static string ToReadableString(Key[] keys)
        {
            if (keys == null || keys.Length == 0)
            {
                return "";
            }
            var stringKeys = Array.ConvertAll(keys, key => key.ToString());
            var sortedStringKeys = stringKeys.OrderBy(s =>
                {
                    var i = specialKeys.FindIndex(sk => sk.Contains(s));
                    var res = i == -1 ? i : int.MaxValue;
                    return res;
                })
                .ToArray();

            return string.Join(" + ", sortedStringKeys);
        }

        public static string ToReadableString(Key key)
        {
            return ToReadableString(new Key[] { key });
        }

        public static string ToReadableString(Keys[] vkeys)
        {
            var keys = Array.ConvertAll(vkeys, k => KeyInterop.KeyFromVirtualKey((int)k));
            return ToReadableString(keys);
        }

        public static string ToReadableString(Keys vkey)
        {
            return ToReadableString(new Keys[] { vkey });
        }

        public static bool IsDown()
        {
            return map.Values.Any(keyPressed => keyPressed);
        }

        public static bool IsDown(Key key)
        {
            if (map.ContainsKey(key))
            {
                return map[key];
            }
            return false;
        }

        public static bool IsDown(Key[] keys)
        {
            return !keys.Any(key => !IsDown(key));
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        public static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            GlobalKeyboard.nCode = nCode;
            GlobalKeyboard.wParam = wParam;
            GlobalKeyboard.lParam = lParam;
            var isDown = nCode >= 0 && wParam == (IntPtr)0x0100; // keydown == 0x0100
            var key = KeyInterop.KeyFromVirtualKey(Marshal.ReadInt32(GlobalKeyboard.lParam));

            GlobalKeyboard.Call(key, isDown);

            return CallNextHookEx(hhk, nCode, wParam, lParam);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
    }
}
