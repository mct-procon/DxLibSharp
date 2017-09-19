using System.Runtime.InteropServices;
using System;

namespace DxLib {
    public static partial class DX {
        public enum Result {
            Error = -1, Success = 0
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DxLib_Init", CharSet = CharSet.Unicode)]
        extern static int dx_DxLib_Init_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DxLib_Init", CharSet = CharSet.Unicode)]
        extern static int dx_DxLib_Init_x64();
        public static Result Init() =>
            (Result)(Environment.Is64BitProcess ? dx_DxLib_Init_x64() : dx_DxLib_Init_x86());

        [DllImport("DxLibW.dll", EntryPoint = "dx_DxLib_End", CharSet = CharSet.Unicode)]
        extern static int dx_DxLib_End_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DxLib_End", CharSet = CharSet.Unicode)]
        extern static int dx_DxLib_End_x64();
        public static Result Finalize() =>
            (Result)(Environment.Is64BitProcess ? dx_DxLib_End_x64() : dx_DxLib_End_x86());

        [DllImport("DxLibW.dll", EntryPoint = "dx_ProcessMessage", CharSet = CharSet.Unicode)]
        extern static int dx_ProcessMessage_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_ProcessMessage", CharSet = CharSet.Unicode)]
        extern static int dx_ProcessMessage_x64();
        public static Result ProcessMessage() =>
            (Result)(Environment.Is64BitProcess ? dx_ProcessMessage_x64() : dx_ProcessMessage_x86());

        [DllImport("DxLibW.dll", EntryPoint = "dx_GetMainWindowHandle", CharSet = CharSet.Unicode)]
        extern static IntPtr dx_GetMainWindowHandle_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_GetMainWindowHandle", CharSet = CharSet.Unicode)]
        extern static IntPtr dx_GetMainWindowHandle_x64();
        public static IntPtr GetMainWindowHandle() =>
            Environment.Is64BitProcess ? dx_GetMainWindowHandle_x64() : dx_GetMainWindowHandle_x86();

        [DllImport("DxLibW.dll", EntryPoint = "dx_WaitTimer", CharSet = CharSet.Unicode)]
        extern static int dx_WaitTimer_x86(int WaitTime);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_WaitTimer", CharSet = CharSet.Unicode)]
        extern static int dx_WaitTimer_x64(int WaitTime);
        public static Result WaitTimer(int WaitTime) =>
            (Result)(Environment.Is64BitProcess ? dx_WaitTimer_x64(WaitTime) : dx_WaitTimer_x86(WaitTime));

        [DllImport("DxLibW.dll", EntryPoint = "dx_SetWindowSizeChangeEnableFlag", CharSet = CharSet.Unicode)]
        extern static int dx_SetWindowSizeChangeEnableFlag_x86([MarshalAs(UnmanagedType.Bool)]bool Flag, [MarshalAs(UnmanagedType.Bool)]bool FitScreen);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_SetWindowSizeChangeEnableFlag", CharSet = CharSet.Unicode)]
        extern static int dx_SetWindowSizeChangeEnableFlag_x64([MarshalAs(UnmanagedType.Bool)]bool Flag, [MarshalAs(UnmanagedType.Bool)]bool FitScreen);
        public static Result SetWindowSizeChangeEnableFlag(bool Flag, bool FitScreen = false) =>
            (Result)(Environment.Is64BitProcess ? dx_SetWindowSizeChangeEnableFlag_x64(Flag, FitScreen) : dx_SetWindowSizeChangeEnableFlag_x86(Flag, FitScreen));

    }
}
