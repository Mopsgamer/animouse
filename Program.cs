using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace animouse
{
    internal static class Program
    {
        public static FormMain formMain;
        public static FormSetupWhiteList formWhiteList;
        public static Shortcut ShortcutAddWhitelist = new Shortcut(new Key[] { Key.LeftCtrl, Key.LeftShift, Key.A });
        public static Shortcut ShortcutRunDVD;
        //
        // Summary:
        //     The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _hookID = SetHook(_proc);
            formWhiteList = new FormSetupWhiteList();
            formMain = new FormMain();
            Application.Run(formMain);
            UnhookWindowsHookEx(_hookID);
        }

        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }

        public static List<string> GetAllProcesses()
        {
            List<string> windowProcessNames = new List<string>();

            EnumWindows((hWnd, lParam) =>
            {
                GetWindowThreadProcessId(hWnd, out uint processId);
                Process process = Process.GetProcessById((int)processId);
                string processName = process.ProcessName;
                if (!windowProcessNames.Contains(processName))
                {
                    windowProcessNames.Add(processName);
                }
                return true; // Continue enumeration
            }, IntPtr.Zero);
            return windowProcessNames;
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;

        public static string InFocusProcess;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private static readonly LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            GlobalKeyboard.nCode = nCode;
            GlobalKeyboard.wParam = wParam;
            GlobalKeyboard.lParam = lParam;
            var isDown = nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN;
            var key = KeyInterop.KeyFromVirtualKey(Marshal.ReadInt32(GlobalKeyboard.lParam));

            IntPtr handle = GetForegroundWindow();
            GetWindowThreadProcessId(handle, out uint processId);
            Process process = Process.GetProcessById((int)processId);
            InFocusProcess = process.ProcessName;
            GlobalKeyboard.Invoke(key, isDown);

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        // Import the necessary WinAPI functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
