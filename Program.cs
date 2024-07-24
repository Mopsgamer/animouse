using GlobalInput;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;


namespace mouseutil
{
    internal static class Program
    {
        public static IntPtr hhk = IntPtr.Zero;
        public static FormMain formMain;
        public static FormSetupWhiteList formWhiteList;
        public static GlobalShortcut ShortcutAddWhitelist = new GlobalShortcut(new Key[] { Key.LeftCtrl, Key.LeftShift, Key.A });
        public static GlobalShortcut ShortcutRunDVD;
        //
        // Summary:
        //     The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalKeyboard.Listen();
            formWhiteList = new FormSetupWhiteList();
            formMain = new FormMain();
            GlobalKeyboard.OnKey += GetFocus;
            Application.Run(formMain);
            GlobalKeyboard.Dispose();
        }

        private static void GetFocus(object sender, EventArgs e)
        {
            IntPtr handle = GetForegroundWindow();
            GetWindowThreadProcessId(handle, out uint processId);
            Process process = Process.GetProcessById((int)processId);
            InFocusProcess = process.ProcessName;
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

        public static string InFocusProcess;

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        // Import the necessary WinAPI functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
    }
}
