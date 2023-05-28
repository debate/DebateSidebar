using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
/*     DANGEROUS TERRITORY
       HERE BE DRAGONS!

             |\___/|
            (,\  /,)\
            /     /  \
           (@_^_@)/   \
            W//W_/     \
          (//) |        \
        (/ /) _|_ /   )  \
      (// /) '/,_ _ _/  (~^-.
    (( // )) ,-{        _    `.
   (( /// ))  '/\      /      |
   (( ///))     `.   {       }
    ((/ ))    .----~-.\   \-'
             ///.----..>   \
              ///-._ _  _ _}
*/



namespace DebateSidebarWordAddIn
{
    public class Hotkeys
    {
        public delegate int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static readonly LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static int HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            Properties.Settings s = Properties.Settings.Default;

            //listen to global keyhook then pass thru to next hook
            // to avoid interference with other applications
            if (nCode != 0 || ((Int64)lParam & (Int64)Math.Pow(2, 30)) > 0 
                || Properties.Settings.Default.Hotkeys == false 
                || Globals.ThisAddIn.isSettingsOpen)
                return (int)CallNextHookEx(_hookID, nCode, wParam, lParam);

            //TODO + instead of ,
            String keyData = ((Keys)wParam).ToString();
            if (Functions.IsKeyDown(Keys.RShiftKey) || Functions.IsKeyDown(Keys.LShiftKey))
                keyData += ", Shift";
            if (Functions.IsKeyDown(Keys.ControlKey))
                keyData += ", Control";
            if (Functions.IsKeyDown(Keys.Menu))
                keyData += ", Alt";


            if (keyData == "Escape")
            {
                Macros.EscPressed();
                return 0;
            }


            //run the macros from settings list orderif matching
            if (keyData == s.k1)
                Macros.InvisibilityMode();
            if (keyData == s.k2)
                Macros.CollapseDocToTags();
            if (keyData == s.k3)
                Macros.AddFlowNote();
            if (keyData == s.k4)
                Macros.Heading1();
            if (keyData == s.k5)
                Macros.toggleSidebar();
            if (keyData == s.k6)
                Macros.toggleSidebar();
            if (keyData == s.k7)
                Macros.toggleSidebar();
            if (keyData == s.k8)
                Macros.toggleSidebar();
            if (keyData == s.k9)
                Macros.toggleSidebar();
            if (keyData == s.k10)
                Macros.toggleSidebar();
            if (keyData == s.k11)
                Macros.toggleSidebar();
            if (keyData == s.k12)
                Macros.toggleSidebar();


            // allows user to set overrides or pass thru
            string matchedAnyMacro = s.k1 + s.k2 + s.k3
                + s.k4 + s.k5 + s.k6 + s.k7 + s.k8 + s.k9
                + s.k10 + s.k11 + s.k12;

            if ( (matchedAnyMacro).Contains(keyData))
                return 1;
            else 
                return (int)CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        public static void Setup()
        {
            _hookID = SetWindowsHookEx(2, _proc, IntPtr.Zero, 
                (uint)Process.GetCurrentProcess().Threads[0].Id);
        }

        public static void Dispose()
        {
            UnhookWindowsHookEx(_hookID);
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);
    }

    public class Functions
    {
        public static bool IsKeyDown(Keys keys)
        {
            return (GetKeyState((int)keys) & 0x8000) == 0x8000;
        }

        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
    }
}