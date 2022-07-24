﻿using System;
using System.Runtime.InteropServices;

namespace ImTryin.WindowsConsoleService;

public static class WindowApi
{
    [DllImport("Kernel32.dll", SetLastError = true)]
    public static extern int GetConsoleProcessList([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] processIds, int processIdsSize);

    [DllImport("Kernel32.dll", SetLastError = true)]
    public static extern IntPtr GetConsoleWindow();

    public enum CommandShow
    {
        Hide = 0,
        ShowNormal = 1,
        Normal = 1,
        ShowMinimized = 2,
        ShowMaximized = 3,
        Maximize = 3,
        ShowNoActivate = 4,
        Show = 5,
        Minimize = 6,
        ShowMinNoActive = 7,
        ShowNa = 8,
        Restore = 9,
        ShowDefault = 10,
        ForceMinimize = 11
    }

    [DllImport("User32.dll", SetLastError = true)]
    public static extern bool ShowWindow(IntPtr windowHandle, CommandShow commandShow);

    [DllImport("User32.dll", SetLastError = true)]
    public static extern bool SetForegroundWindow(IntPtr windowHandle);
}