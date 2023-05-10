using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
           
    if (nCode != 0 || ((Int64)lParam & (Int64)Math.Pow(2, 30)) > 0  || Properties.Settings.Default.Hotkeys == false || Globals.ThisAddIn.isSettingsOpen)
        return (int)CallNextHookEx(_hookID, nCode, wParam, lParam);
                
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

    if (keyData == s.k11)
    {
        Macros.refreshDoc();
        return 1;
    }
  
                
    return (int)CallNextHookEx(_hookID, nCode, wParam, lParam);         
}

public static void Setup()
{
    _hookID = SetWindowsHookEx(2, _proc, IntPtr.Zero, (uint)Process.GetCurrentProcess().Threads[0].Id);
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