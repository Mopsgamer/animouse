using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace animouse
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

    public class Shortcut
    {
        public readonly Key[] KeyArray;

        public Shortcut(Key[] keys)
        {
            KeyArray = keys;
        }
        public Shortcut(Key key)
        {
            KeyArray = new Key[] { key };
        }
        public Shortcut(string str)
        {
            var valid = TryParse(str, out Shortcut newThis);
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

        static public bool TryParse(string str, out Shortcut shortcut)
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
                shortcut = new Shortcut(keys.ToArray());
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

        public bool IsDown()
        {
            return GlobalKeyboard.IsDown(KeyArray);
        }
    }

    public class GlobalKeyboard
    {
        public static int nCode;
        public static IntPtr wParam;
        public static IntPtr lParam;
        /// <summary>
        /// True for pressed keys.
        /// </summary>
        private static readonly Dictionary<Key, bool> map = new Dictionary<Key, bool>();
        private static readonly List<string> specialKeys = new List<string> { "Ctrl", "Alt", "Shift" };
        public static Shortcut lastShortcut;
        public static Key lastKeyDown;
        public static Key lastKeyUp;
        public static void Invoke(Key key, bool isDown)
        {
            map[key] = isDown;

            if (isDown)
            {
                lastKeyDown = key;

                lastShortcut = new Shortcut(
                    map
                        .Where(p => IsDown(p.Key))
                        .Select(p => p.Key)
                        .ToArray()
                    );

                if (KeyDown != null) KeyDown.Invoke(null, new GlobalKeyEventArgs(key, isDown));
            }
            else
            {
                lastKeyUp = key;

                if (KeyUp != null) KeyUp.Invoke(null, new GlobalKeyEventArgs(key, isDown));
            }
            if (Key != null) Key.Invoke(null, new GlobalKeyEventArgs(key, isDown));
        }

        public static event EventHandler KeyDown;
        public static event EventHandler KeyUp;
        public static event EventHandler Key;

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
                    var res = i ==-1 ? i : int.MaxValue;
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
    }
}
