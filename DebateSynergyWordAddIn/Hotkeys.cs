using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Core;


namespace DebateSynergyWordAddIn
{
    public class Hotkeys
    {
        public delegate int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;       
        private const int WH_KEYBOARD = 2;
        private const int HC_ACTION = 0;

        public static void SetHook()
        {


            _hookID = SetWindowsHookEx(WH_KEYBOARD, _proc, IntPtr.Zero, (uint)Process.GetCurrentProcess().Threads[0].Id );
        }

        public static void ReleaseHook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static int HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            Properties.Settings s = Properties.Settings.Default;
            int PreviousStateBit = 31;
            bool KeyWasAlreadyPressed = false;

            Int64 bitmask = (Int64)Math.Pow(2, (PreviousStateBit - 1));


            try
            {

                if (nCode < 0 || Properties.Settings.Default.Hotkeys == false || Globals.ThisAddIn.isSettingsOpen == true)
                {
                     return (int)CallNextHookEx(_hookID, nCode, wParam, lParam);
                }
                else
                {
                    if (nCode == HC_ACTION)
                    {
                        KeyWasAlreadyPressed = ((Int64)lParam & bitmask) > 0;
                        
                        String keyData = ((Keys)wParam).ToString();
                        if (Functions.IsKeyDown(Keys.RShiftKey) || Functions.IsKeyDown(Keys.LShiftKey))
                            keyData += ", Shift";
                        if (Functions.IsKeyDown(Keys.ControlKey))
                            keyData+=", Control";
                        if (Functions.IsKeyDown(Keys.Menu))
                            keyData+=", Alt";
                       
                        

                        if (KeyWasAlreadyPressed == false)
                        {
                            if (keyData == "Escape")
                            {
                                Macros.EscPressed();
                                return 0;
                            }
                            

                            
                            if (keyData == s.k1)
                            {
                                Macros.Underline();
                                return 1;
                            }
                            if (keyData == s.k2)
                            {
                                Macros.Highlight();
                                return 1;
                            }

                            if (keyData == s.k3)
                            {
                                Macros.PasteUnformatted();
                                return 1;
                            }

                            if (keyData == s.k4)
                            {
                                Macros.RemoveReturns();
                                return 1;
                            }

                            if (keyData == s.k5)
                            {
                                Macros.Heading1();
                                return 1;
                            }

                            if (keyData == s.k6)
                            {
                                Macros.Heading2();
                                return 1;
                            }

                            if (keyData == s.k7)
                            {
                                Macros.Heading3();
                                return 1;
                            }

                            if (keyData == s.k8)
                            {
                                Macros.Heading4();
                                return 1;
                            }
                            if (keyData == s.k9)
                            {
                                Macros.SendToSpeech();
                                return 1;
                            }
                            if (keyData == s.k10)
                            {
                                Macros.MinimizeUnread();
                                return 1;
                            }
                            if (keyData == s.k11)
                            {


                                Macros.refreshDoc();
                                return 1;
                            }
                            if (keyData == s.k12)
                            {
                                
                                Macros.switchDocuments();
                                return 1;
                            }


                        }


                    }
                    return (int)CallNextHookEx(_hookID, nCode, wParam, lParam);
                }
            }
            catch (Exception e)
            {
               Debug.WriteLine(e);
               return (int)CallNextHookEx(_hookID, nCode, wParam, lParam);
            }
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
        static extern short GetKeyState(int nVirtKey);


    }
}
