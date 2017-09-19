using System.Runtime.InteropServices;
using System;

namespace DxLib {
    public static partial class DX {
        public enum KeyInput : int {
            Back = 14,
            Tab = 15,
            Return = 28,
            LShift = 42,
            RShift = 54,
            LControl = 29,
            RControl = 157,
            Escape = 1,
            Space = 57,
            PageUp = 201, 
            PageDown = 209,
            End = 207,
            Home = 199,
            Left = 203,
            Up = 200,
            Right = 205, 
            Down = 208,
            Insert = 210,
            Delete = 211,
            Minus = 12,
            Yen = 125,
            PrevTrack = 144,
            Period = 52,
            Slash = 53,
            LeftAlt = 56,
            RightAlt = 184,
            Scroll = 70,
            SemiColon = 39,
            Colon = 146,
            LeftBracket = 26,
            RightBracket = 27,
            At = 145,
            BackSlash = 43,
            Comma = 51,
            Kanji = 148,
            Convert = 121,
            NoConvert = 123,
            Kana = 112,
            Apps = 221,
            CapsLock = 58,
            SystemRequest = 183,
            Pause = 197,
            LeftWindows = 219,
            RightWindows = 220,
            NumLock = 69,
            NumPad0 = 82,
            NumPad1 = 79,
            NumPad2 = 80,
            NumPad3 = 81,
            NumPad4 = 75,
            NumPad5 = 76,
            NumPad6 = 77,
            NumPad7 = 71,
            NumPad8 = 72,
            NumPad9 = 73,
            Multiply = 55,
            Add = 78,
            Substract = 74,
            Decimal = 83,
            Divide = 181,
            NumPadEnter = 156,
            F1 = 59,
            F2 = 60, 
            F3 = 61,
            F4 = 62,
            F5 = 63,
            F6 = 64,
            F7 = 65,
            F8 = 66,
            F9 = 67,
            F10 = 68,
            F11 = 87,
            F12 = 88,
            A = 30,
            B = 48,
            C = 46,
            D = 32,
            E = 18,
            F = 33,
            G = 34,
            H = 35,
            I = 23,
            J = 36,
            K = 37,
            L = 38,
            M = 50, 
            N = 49,
            O = 24,
            P = 25,
            Q = 16,
            R = 19,
            S = 31,
            T = 20,
            U = 22,
            V = 47,
            W = 17,
            X = 45,
            Y = 21,
            Z = 44,
            D0 = 11,
            D1 = 2,
            D2 = 3,
            D3 = 4,
            D4 = 5,
            D5 = 6,
            D6 = 7,
            D7 = 8,
            D8 = 9,
            D9 = 10
        }

        public enum CheckInputMode {
            Key = 0b001, Pad = 0b010, Mouse = 0b100, All = Key
        }

        public struct KeyState {
            internal byte[] Data;

            public bool this[KeyInput i] {
                get => Data[(int)i] == 1;
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_WaitKey", CharSet = CharSet.Unicode)]
        extern static int dx_WaitKey_x86();
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_WaitKey", CharSet = CharSet.Unicode)]
        extern static int dx_WaitKey_x64();
        public static KeyInput WaitKey() =>
            (KeyInput)(Environment.Is64BitProcess ? dx_WaitKey_x64() : dx_WaitKey_x86());

        [DllImport("DxLibW.dll", EntryPoint = "dx_CheckHitKey", CharSet = CharSet.Unicode)]
        [return : MarshalAs(UnmanagedType.Bool)]
        extern static bool dx_CheckHitKey_x86(int KeyCode);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_CheckHitKey", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        extern static bool dx_CheckHitKey_x64(int KeyCode);
        public static bool CheckHitKey(KeyInput KeyCode) =>
            Environment.Is64BitProcess ? dx_CheckHitKey_x64((int)(KeyCode)) : dx_CheckHitKey_x86((int)(KeyCode));


        [DllImport("DxLibW.dll", EntryPoint = "dx_CheckHitKeyAll", CharSet = CharSet.Unicode)]
        extern static int dx_CheckHitKeyAll_x86(int CheckType);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_CheckHitKeyAll", CharSet = CharSet.Unicode)]
        extern static int dx_CheckHitKeyAll_x64(int CheckType);
        public static Result CheckHitKeyAll(int CheckType = (int)CheckInputMode.All) =>
            (Result)(Environment.Is64BitProcess ? dx_CheckHitKeyAll_x64(CheckType) : dx_CheckHitKeyAll_x86(CheckType));

        [DllImport("DxLibW.dll", EntryPoint = "dx_GetHitKeyStateAll", CharSet = CharSet.Unicode)]
        extern static int dx_GetHitKeyStateAll_x86([In, Out] byte[] KeyStateArray);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_GetHitKeyStateAll", CharSet = CharSet.Unicode)]
        extern static int dx_GetHitKeyStateAll_x64([In, Out] byte[] KeyStateArray);
        public static (KeyState, Result) GetHitKeyStateAll() {
            KeyState result = new KeyState();
            result.Data = new byte[256];
            Result res = (Result)(Environment.Is64BitProcess ? dx_GetHitKeyStateAll_x64(result.Data) : dx_GetHitKeyStateAll_x86(result.Data));
            return (result, res);
        }
    }
}
