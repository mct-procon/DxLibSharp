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

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawString", CharSet = CharSet.Unicode)]
        extern static int dx_DrawString_x86(int X, int Y, string Text, uint Color, uint EdgeColor);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawString", CharSet = CharSet.Unicode)]
        extern static int dx_DrawString_x64(int X, int Y, string Text, uint Color, uint EdgeColor);

        public static Result DrawString(int X, int Y, uint Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, Text, Color, 0) : dx_DrawString_x86(X, Y, Text, Color, 0));
        public static Result DrawStringWithEdge(int X, int Y, uint Color, uint EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, Text, Color, EdgeColor) : dx_DrawString_x86(X, Y, Text, Color, EdgeColor));

        public static Result DrawStringWithEdge(int X, int Y, Color Color, Color EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, Text, Color.Co, EdgeColor.Co) : dx_DrawString_x86(X, Y, Text, Color.Co, EdgeColor.Co));
        public static Result DrawString(int X, int Y, Color Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, Text, Color.Co, 0) : dx_DrawString_x86(X, Y, Text, Color.Co, 0));

        public static Result DrawString(int X, int Y, uint Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, string.Format(Text, args), Color, 0) : dx_DrawString_x86(X, Y, string.Format(Text, args), Color, 0));
        public static Result DrawString(int X, int Y, Color Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, string.Format(Text, args), Color.Co, 0) : dx_DrawString_x86(X, Y, string.Format(Text, args), Color.Co, 0));

        public static Result DrawStringWithEdge(int X, int Y, uint Color, uint EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, string.Format(Text, args), Color, EdgeColor) : dx_DrawString_x86(X, Y, string.Format(Text, args), Color, EdgeColor));
        public static Result DrawStringWithEdge(int X, int Y, Color Color, Color EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawString_x64(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co) : dx_DrawString_x86(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawVString", CharSet = CharSet.Unicode)]
        extern static int dx_DrawVString_x86(int X, int Y, string Text, uint Color, uint EdgeColor);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawVString", CharSet = CharSet.Unicode)]
        extern static int dx_DrawVString_x64(int X, int Y, string Text, uint Color, uint EdgeColor);

        public static Result DrawVStringWithEdge(int X, int Y, uint Color, uint EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, Text, Color, EdgeColor) : dx_DrawVString_x86(X, Y, Text, Color, EdgeColor));
        public static Result DrawVString(int X, int Y, uint Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, Text, Color, 0) : dx_DrawVString_x86(X, Y, Text, Color, 0));


        public static Result DrawVString(int X, int Y, Color Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, Text, Color.Co, 0) : dx_DrawVString_x86(X, Y, Text, Color.Co, 0));
        public static Result DrawVStringWithEdge(int X, int Y, Color Color, Color EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, Text, Color.Co, EdgeColor.Co) : dx_DrawVString_x86(X, Y, Text, Color.Co, EdgeColor.Co));


        public static Result DrawVString(int X, int Y, uint Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, string.Format(Text, args), Color, 0) : dx_DrawVString_x86(X, Y, string.Format(Text, args), Color, 0));
        public static Result DrawVString(int X, int Y, Color Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, string.Format(Text, args), Color.Co, 0) : dx_DrawVString_x86(X, Y, string.Format(Text, args), Color.Co, 0));

        public static Result DrawVStringWithEdge(int X, int Y, uint Color, uint EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, string.Format(Text, args), Color, EdgeColor) : dx_DrawVString_x86(X, Y, string.Format(Text, args), Color, EdgeColor));
        public static Result DrawVStringWithEdge(int X, int Y, Color Color, Color EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVString_x64(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co) : dx_DrawVString_x86(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawStringF", CharSet = CharSet.Unicode)]
        extern static int dx_DrawStringF_x86(float X, float Y, string Text, uint Color, uint EdgeColor);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawStringF", CharSet = CharSet.Unicode)]
        extern static int dx_DrawStringF_x64(float X, float Y, string Text, uint Color, uint EdgeColor);

        public static Result DrawStringWithEdge(float X, float Y, uint Color, uint EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, Text, Color, EdgeColor) : dx_DrawStringF_x86(X, Y, Text, Color, EdgeColor));
        public static Result DrawString(float X, float Y, uint Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, Text, Color, 0) : dx_DrawStringF_x86(X, Y, Text, Color, 0));


        public static Result DrawString(float X, float Y, Color Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, Text, Color.Co, 0) : dx_DrawStringF_x86(X, Y, Text, Color.Co, 0));
        public static Result DrawStringWithEdge(float X, float Y, Color Color, Color EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, Text, Color.Co, EdgeColor.Co) : dx_DrawStringF_x86(X, Y, Text, Color.Co, EdgeColor.Co));


        public static Result DrawString(float X, float Y, uint Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, string.Format(Text, args), Color, 0) : dx_DrawStringF_x86(X, Y, string.Format(Text, args), Color, 0));
        public static Result DrawString(float X, float Y, Color Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, string.Format(Text, args), Color.Co, 0) : dx_DrawStringF_x86(X, Y, string.Format(Text, args), Color.Co, 0));

        public static Result DrawStringWithEdge(float X, float Y, uint Color, uint EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, string.Format(Text, args), Color, EdgeColor) : dx_DrawStringF_x86(X, Y, string.Format(Text, args), Color, EdgeColor));
        public static Result DrawStringWithEdge(float X, float Y, Color Color, Color EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawStringF_x64(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co) : dx_DrawStringF_x86(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawVStringF", CharSet = CharSet.Unicode)]
        extern static int dx_DrawVStringF_x86(float X, float Y, string Text, uint Color, uint EdgeColor);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawVStringF", CharSet = CharSet.Unicode)]
        extern static int dx_DrawVStringF_x64(float X, float Y, string Text, uint Color, uint EdgeColor);

        public static Result DrawVStringWithEdge(float X, float Y, uint Color, uint EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, Text, Color, EdgeColor) : dx_DrawVStringF_x86(X, Y, Text, Color, EdgeColor));
        public static Result DrawVString(float X, float Y, uint Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, Text, Color, 0) : dx_DrawVStringF_x86(X, Y, Text, Color, 0));


        public static Result DrawVString(float X, float Y, Color Color, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, Text, Color.Co, 0) : dx_DrawVStringF_x86(X, Y, Text, Color.Co, 0));
        public static Result DrawVStringWithEdge(float X, float Y, Color Color, Color EdgeColor, string Text) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, Text, Color.Co, EdgeColor.Co) : dx_DrawVStringF_x86(X, Y, Text, Color.Co, EdgeColor.Co));


        public static Result DrawVString(float X, float Y, uint Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, string.Format(Text, args), Color, 0) : dx_DrawVStringF_x86(X, Y, string.Format(Text, args), Color, 0));
        public static Result DrawVString(float X, float Y, Color Color, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, string.Format(Text, args), Color.Co, 0) : dx_DrawVStringF_x86(X, Y, string.Format(Text, args), Color.Co, 0));

        public static Result DrawVStringWithEdge(float X, float Y, uint Color, uint EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, string.Format(Text, args), Color, EdgeColor) : dx_DrawVStringF_x86(X, Y, string.Format(Text, args), Color, EdgeColor));
        public static Result DrawVStringWithEdge(float X, float Y, Color Color, Color EdgeColor, string Text, params object[] args) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawVStringF_x64(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co) : dx_DrawVStringF_x86(X, Y, string.Format(Text, args), Color.Co, EdgeColor.Co));


        [DllImport("DxLibW.dll", EntryPoint = "dx_clsDx", CharSet = CharSet.Unicode)]
        extern static int dx_clsDx_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_clsDx", CharSet = CharSet.Unicode)]
        extern static int dx_clsDx_x64();
        public static Result ClsDx() =>
            (Result)(Environment.Is64BitProcess ? dx_clsDx_x64() : dx_clsDx_x86());

        [DllImport("DxLibW.dll", EntryPoint = "dx_SetFontSize", CharSet = CharSet.Unicode)]
        extern static int dx_SetFontSize_x86(int FontSize);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_SetFontSize", CharSet = CharSet.Unicode)]
        extern static int dx_SetFontSize_x64(int FontSize);
        public static Result SetFontSize(int FontSize) =>
            (Result)(Environment.Is64BitProcess ? dx_SetFontSize_x64(FontSize) : dx_SetFontSize_x86(FontSize));

        [DllImport("DxLibW.dll", EntryPoint = "dx_GetFontSize", CharSet = CharSet.Unicode)]
        extern static int dx_GetFontSize_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_GetFontSize", CharSet = CharSet.Unicode)]
        extern static int dx_GetFontSize_x64();
        public static int GetFontSize() =>
            Environment.Is64BitProcess ? dx_GetFontSize_x64() : dx_GetFontSize_x86();

        public enum FontType : int {
            Default = -1, Normal = 0, Edge = 1,
            Antialiasing = 2, Antialiasing_4x4 = 18, Antialiasing_8x8 = 34,
            AntialiasingWithEdge = 3, AntialiasingWithEdge_4x4 = 19, AntialiasingWithEdge_8x8 = 35
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_ChangeFontType", CharSet = CharSet.Unicode)]
        extern static int dx_ChangeFontType_x86(int FontType);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_ChangeFontType", CharSet = CharSet.Unicode)]
        extern static int dx_ChangeFontType_x64(int FontType);
        public static Result ChangeFontType(FontType FontType) =>
            (Result)(Environment.Is64BitProcess ? dx_ChangeFontType_x64((int)FontType) : dx_ChangeFontType_x86((int)FontType));

    }
}
