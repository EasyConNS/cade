using System.Runtime.InteropServices;

namespace cade
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static readonly Mutex Mutex = new(true, "{EasyCon-Cade}");
        [STAThread]
        static void Main(string[] args)
        {
            if (Mutex.WaitOne(TimeSpan.Zero, true))
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                try
                {
                    Application.Run(new MainForm());
                }
                finally
                {
                    Mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show("已经有一个程序在运行了");
                NativeMethods.PostMessage((IntPtr)NativeMethods.HwndBroadcast, NativeMethods.WmShowme, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }

    // this class just wraps some Win32 stuff that we're going to use
    internal class NativeMethods
    {
        public const int HwndBroadcast = 0xFFFF;
        public static readonly int WmShowme = RegisterWindowMessage("WM_SHOWME");

        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern int RegisterWindowMessage(string message);
    }
}