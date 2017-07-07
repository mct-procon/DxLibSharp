using System.Runtime.InteropServices;
using System;

namespace DxLib {
    public static partial class DX {
        //[DllImport("DxLibW.dll", EntryPoint = "dx_printfDx", CharSet = CharSet.Unicode)]
        //extern static int dx_printfDx_x86(string FormatString, __arglist);
        //[DllImport("DxLibW_x64.dll", EntryPoint = "dx_printfDx", CharSet = CharSet.Unicode)]
        //extern static int dx_printfDx_x64(string FormatString, __arglist);

        [DllImport("DxLibW.dll", EntryPoint = "dx_putsDx", CharSet = CharSet.Unicode)]
        extern static int dx_putsDx_x86(string Text, [MarshalAs(UnmanagedType.Bool)]bool NewLine);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_putsDx", CharSet = CharSet.Unicode)]
        extern static int dx_putsDx_x64(string Text, [MarshalAs(UnmanagedType.Bool)]bool NewLine);
        public static Result PutsDx(string Text, bool NewLine = true) =>
            (Result)(Environment.Is64BitProcess ? dx_putsDx_x64(Text, NewLine) : dx_putsDx_x86(Text, NewLine));

        public static Result WriteDx(string StringFormat, params object[] Args) =>
            (Result)(Environment.Is64BitProcess ? dx_putsDx_x64(String.Format(StringFormat, Args), false) : dx_putsDx_x86(String.Format(StringFormat, Args), false));
        public static Result WriteLineDx(string StringFormat, params object[] Args) =>
            (Result)(Environment.Is64BitProcess ? dx_putsDx_x64(String.Format(StringFormat, Args), true) : dx_putsDx_x86(String.Format(StringFormat, Args), true));

        [DllImport("DxLibW.dll", EntryPoint = "dx_clsDx", CharSet = CharSet.Unicode)]
        extern static int dx_clsDx_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_clsDx", CharSet = CharSet.Unicode)]
        extern static int dx_clsDx_x64();
        public static Result ClsDx() =>
            (Result)(Environment.Is64BitProcess ? dx_clsDx_x64() : dx_clsDx_x86());
    }
}
