﻿using System.Runtime.InteropServices;
using System;

namespace DxLib {
    public static partial class DX {
        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawLine", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLine_x86(int x1, int y1, int x2, int y2, uint Color, int Thickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawLine", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLine_x64(int x1, int y1, int x2, int y2, uint Color, int Thickness);
        public static Result DrawLine(int x1, int y1, int x2, int y2, uint Color, int Thickness = 1) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawLine_x64(x1, y1, x2, y2, Color, Thickness) : dx_DrawLine_x86(x1, y1, x2, y2, Color, Thickness));
        public static Result DrawLine(int x1, int y1, int x2, int y2, Color Color, int Thickness = 1) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawLine_x64(x1, y1, x2, y2, Color.Co, Thickness) : dx_DrawLine_x86(x1, y1, x2, y2, Color.Co, Thickness));


        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawLineAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLineAA_x86(float x1, float y1, float x2, float y2, uint Color, float Thickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawLineAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLineAA_x64(float x1, float y1, float x2, float y2, uint Color, float Thickness);
        public static Result DrawLineAA(float x1, float y1, float x2, float y2, uint Color, float Thickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawLineAA_x64(x1, y1, x2, y2, Color, Thickness) : dx_DrawLineAA_x86(x1, y1, x2, y2, Color, Thickness));
        public static Result DrawLineAA(float x1, float y1, float x2, float y2, Color Color, float Thickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawLineAA_x64(x1, y1, x2, y2, Color.Co, Thickness) : dx_DrawLineAA_x86(x1, y1, x2, y2, Color.Co, Thickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawBox", CharSet = CharSet.Unicode)]
        extern static int dx_DrawBox_x86(int x1, int y1, int x2, int y2, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawBox", CharSet = CharSet.Unicode)]
        extern static int dx_DrawBox_x64(int x1, int y1, int x2, int y2, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        public static Result DrawBox(int x1, int y1, int x2, int y2, uint Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawBox_x64(x1, y1, x2, y2, Color, FillFlag) : dx_DrawBox_x86(x1, y1, x2, y2, Color, FillFlag));
        public static Result DrawBox(int x1, int y1, int x2, int y2, Color Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawBox_x64(x1, y1, x2, y2, Color.Co, FillFlag) : dx_DrawBox_x86(x1, y1, x2, y2, Color.Co, FillFlag));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawBoxAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawBoxAA_x86(float x1, float y1, float x2, float y2, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawBoxAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawBoxAA_x64(float x1, float y1, float x2, float y2, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        public static Result DrawBoxAA(float x1, float y1, float x2, float y2, uint Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawBoxAA_x86(x1, y1, x2, y2, Color, FillFlag, LineThickness) : dx_DrawBoxAA_x64(x1, y1, x2, y2, Color, FillFlag, LineThickness));
        public static Result DrawBoxAA(float x1, float y1, float x2, float y2, Color Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawBoxAA_x86(x1, y1, x2, y2, Color.Co, FillFlag, LineThickness) : dx_DrawBoxAA_x64(x1, y1, x2, y2, Color.Co, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawFillBox", CharSet = CharSet.Unicode)]
        extern static int dx_DrawFillBox_x86(int x1, int y1, int x2, int y2, uint Color);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawFillBox", CharSet = CharSet.Unicode)]
        extern static int dx_DrawFillBox_x64(int x1, int y1, int x2, int y2, uint Color);
        public static Result DrawFillBox(int x1, int y1, int x2, int y2, uint Color) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawFillBox_x86(x1, y1, x2, y2, Color) : dx_DrawFillBox_x64(x1, y1, x2, y2, Color));
        public static Result DrawFillBox(int x1, int y1, int x2, int y2, Color Color) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawFillBox_x86(x1, y1, x2, y2, Color.Co) : dx_DrawFillBox_x64(x1, y1, x2, y2, Color.Co));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawLineBox", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLineBox_x86(int x1, int y1, int x2, int y2, uint Color);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawLineBox", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLineBox_x64(int x1, int y1, int x2, int y2, uint Color);
        public static Result DrawLineBox(int x1, int y1, int x2, int y2, uint Color) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawLineBox_x64(x1, y1, x2, y2, Color) : dx_DrawLineBox_x86(x1, y1, x2, y2, Color));
        public static Result DrawLineBox(int x1, int y1, int x2, int y2, Color Color) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawLineBox_x64(x1, y1, x2, y2, Color.Co) : dx_DrawLineBox_x86(x1, y1, x2, y2, Color.Co));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCircle", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCircle_x86(int x, int y, int r, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, int LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCircle", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCircle_x64(int x, int y, int r, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, int LineThickness);
        public static Result DrawCircle(int x, int y, int r, uint Color, bool FillFlag = true, int LineThickness = 1) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawCircle_x64(x, y, r, Color, FillFlag, LineThickness) : dx_DrawCircle_x86(x, y, r, Color, FillFlag, LineThickness));
        public static Result DrawCircle(int x, int y, int r, Color Color, bool FillFlag = true, int LineThickness = 1) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawCircle_x64(x, y, r, Color.Co, FillFlag, LineThickness) : dx_DrawCircle_x86(x, y, r, Color.Co, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCircleAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCircleAA_x86(float x, float y, float r, int posnum, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCircleAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCircleAA_x64(float x, float y, float r, int posnum, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        public static Result DrawCircleAA(float x, float y, float r, int posnum, uint Color, bool FillFlag = true, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawCircleAA_x64(x, y, r, posnum, Color, FillFlag, LineThickness) : dx_DrawCircleAA_x86(x, y, r, posnum, Color, FillFlag, LineThickness));
        public static Result DrawCircleAA(float x, float y, float r, int posnum, Color Color, bool FillFlag = true, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawCircleAA_x64(x, y, r, posnum, Color.Co, FillFlag, LineThickness) : dx_DrawCircleAA_x86(x, y, r, posnum, Color.Co, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawOval", CharSet = CharSet.Unicode)]
        extern static int dx_DrawOval_x86(int x, int y, int rx, int ry, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, int LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawOval", CharSet = CharSet.Unicode)]
        extern static int dx_DrawOval_x64(int x, int y, int rx, int ry, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, int LineThickness);
        public static Result DrawOval(int x, int y, int rx, int ry, uint Color, bool FillFlag = true, int LineThickness = 1) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawOval_x64(x, y, rx, ry, Color, FillFlag, LineThickness) : dx_DrawOval_x86(x, y, rx, ry, Color, FillFlag, LineThickness));
        public static Result DrawOval(int x, int y, int rx, int ry, Color Color, bool FillFlag = true, int LineThickness = 1) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawOval_x64(x, y, rx, ry, Color.Co, FillFlag, LineThickness) : dx_DrawOval_x86(x, y, rx, ry, Color.Co, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawOvalAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawOvalAA_x86(float x, float y, float rx, float ry, int posnum, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawOvalAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawOvalAA_x64(float x, float y, float rx, float ry, int posnum, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        public static Result DrawOvalAA(float x, float y, float rx, float ry, int posnum, Color Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawOvalAA_x64(x, y, rx, ry, posnum, Color.Co,FillFlag, LineThickness) : dx_DrawOvalAA_x86(x, y, rx, ry, posnum, Color.Co,FillFlag, LineThickness));
        public static Result DrawOvalAA(float x, float y, float rx, float ry, int posnum, uint Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawOvalAA_x64(x, y, rx, ry, posnum, Color, FillFlag, LineThickness) : dx_DrawOvalAA_x86(x, y, rx, ry, posnum, Color, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawOval_Rect", CharSet = CharSet.Unicode)]
        extern static int dx_DrawOval_Rect_x86(int x1, int y1, int x2, int y2, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawOval_Rect", CharSet = CharSet.Unicode)]
        extern static int dx_DrawOval_Rect_x64(int x1, int y1, int x2, int y2, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        public static Result DrawOval_Rect(int x1, int y1, int x2, int y2, Color Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawOval_Rect_x64(x1, y1, x2, y2, Color.Co, FillFlag) : dx_DrawOval_Rect_x86(x1, y1, x2, y2, Color.Co, FillFlag));
        public static Result DrawOval_Rect(int x1, int y1, int x2, int y2, uint Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawOval_Rect_x64(x1, y1, x2, y2, Color, FillFlag) : dx_DrawOval_Rect_x86(x1, y1, x2, y2, Color, FillFlag));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawTriangle", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangle_x86(int x1, int y1, int x2, int y2, int x3, int y3, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawTriangle", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangle_x64(int x1, int y1, int x2, int y2, int x3, int y3, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        public static Result DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Color Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawTriangle_x64(x1, y1, x2, y2, x3, y3, Color.Co, FillFlag) : dx_DrawTriangle_x86(x1, y1, x2, y2, x3, y3, Color.Co, FillFlag));
        public static Result DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3, uint Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawTriangle_x64(x1, y1, x2, y2, x3, y3, Color, FillFlag) : dx_DrawTriangle_x86(x1, y1, x2, y2, x3, y3, Color, FillFlag));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawTriangleAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangleAA_x86(float x1, float y1, float x2, float y2, float x3, float y3, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawTriangleAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangleAA_x64(float x1, float y1, float x2, float y2, float x3, float y3, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        public static Result DrawTriangleAA(float x1, float y1, float x2, float y2, float x3, float y3, Color Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawTriangleAA_x64(x1, y1, x2, y2, x3, y3, Color.Co, FillFlag, LineThickness) : dx_DrawTriangleAA_x86(x1, y1, x2, y2, x3, y3, Color.Co, FillFlag, LineThickness));
        public static Result DrawTriangleAA(float x1, float y1, float x2, float y2, float x3, float y3, uint Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawTriangleAA_x64(x1, y1, x2, y2, x3, y3, Color, FillFlag, LineThickness) : dx_DrawTriangleAA_x86(x1, y1, x2, y2, x3, y3, Color, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawQuadrangle", CharSet = CharSet.Unicode)]
        extern static int dx_DrawQuadrangle_x86(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawQuadrangle", CharSet = CharSet.Unicode)]
        extern static int dx_DrawQuadrangle_x64(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        public static Result DrawQuadrangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, Color Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawQuadrangle_x64(x1, y1, x2, y2, x3, y3, x4, y4, Color.Co, FillFlag) : dx_DrawQuadrangle_x86(x1, y1, x2, y2, x3, y3, x4, y4, Color.Co, FillFlag));
        public static Result DrawQuadrangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, uint Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawQuadrangle_x64(x1, y1, x2, y2, x3, y3, x4, y4, Color, FillFlag) : dx_DrawQuadrangle_x86(x1, y1, x2, y2, x3, y3, x4, y4, Color, FillFlag));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawQuadrangleAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawQuadrangleAA_x86(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawQuadrangleAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawQuadrangleAA_x64(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        public static Result DrawQuadrangleAA(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, Color Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawQuadrangleAA_x64(x1, y1, x2, y2, x3, y3, x4, y4, Color.Co, FillFlag, LineThickness) : dx_DrawQuadrangleAA_x86(x1, y1, x2, y2, x3, y3, x4, y4, Color.Co, FillFlag, LineThickness));
        public static Result DrawQuadrangleAA(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, uint Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawQuadrangleAA_x64(x1, y1, x2, y2, x3, y3, x4, y4, Color, FillFlag, LineThickness) : dx_DrawQuadrangleAA_x86(x1, y1, x2, y2, x3, y3, x4, y4, Color, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawRoundRect", CharSet = CharSet.Unicode)]
        extern static int dx_DrawRoundRect_x86(int x1, int y1, int x2, int y2, int rx, int ry, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawRoundRect", CharSet = CharSet.Unicode)]
        extern static int dx_DrawRoundRect_x64(int x1, int y1, int x2, int y2, int rx, int ry, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag);
        public static Result DrawRoundRect(int x1, int y1, int x2, int y2, int rx, int ry, Color Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawRoundRect_x64(x1, y1, x2, y2, rx, ry, Color.Co, FillFlag) : dx_DrawRoundRect_x86(x1, y1, x2, y2, rx, ry, Color.Co, FillFlag));
        public static Result DrawRoundRect(int x1, int y1, int x2, int y2, int rx, int ry, uint Color, bool FillFlag) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawRoundRect_x64(x1, y1, x2, y2, rx, ry, Color, FillFlag) : dx_DrawRoundRect_x86(x1, y1, x2, y2, rx, ry, Color, FillFlag));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawRoundRectAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawRoundRectAA_x86(float x1, float y1, float x2, float y2, float rx, float ry, int posnum, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawRoundRectAA", CharSet = CharSet.Unicode)]
        extern static int dx_DrawRoundRectAA_x64(float x1, float y1, float x2, float y2, float rx, float ry, int posnum, uint Color, [MarshalAs(UnmanagedType.Bool)]bool FillFlag, float LineThickness);
        public static Result DrawRoundRectAA(float x1, float y1, float x2, float y2, float rx, float ry, int posnum, Color Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawRoundRectAA_x64(x1, y1, x2, y2, rx, ry, posnum, Color.Co, FillFlag, LineThickness) : dx_DrawRoundRectAA_x86(x1, y1, x2, y2, rx, ry, posnum, Color.Co, FillFlag, LineThickness));
        public static Result DrawRoundRectAA(float x1, float y1, float x2, float y2, float rx, float ry, int posnum, uint Color, bool FillFlag, float LineThickness = 1.0f) =>
            (Result)(Environment.Is64BitProcess ? dx_DrawRoundRectAA_x64(x1, y1, x2, y2, rx, ry, posnum, Color, FillFlag, LineThickness) : dx_DrawRoundRectAA_x86(x1, y1, x2, y2, rx, ry, posnum, Color, FillFlag, LineThickness));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawPixel", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixel_x86(int x, int y, uint Color);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawPixel", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixel_x64(int x, int y, uint Color);
        public static Result DrawPixel(int x, int y, uint Color) => (Result)(Environment.Is64BitProcess ? dx_DrawPixel_x64(x, y, Color) : dx_DrawPixel_x86(x, y, Color));
        public static Result DrawPixel(int x, int y, Color Color) => (Result)(Environment.Is64BitProcess ? dx_DrawPixel_x64(x, y, Color.Co) : dx_DrawPixel_x86(x, y, Color.Co));

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawPixelSet", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixelSet_x86([In, Out] POINTDATA[] PointDataArray, int Num);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawPixelSet", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixelSet_x64([In, Out] POINTDATA[] PointDataArray, int Num);
        public static int DrawPixelSet([In, Out] POINTDATA[] PointDataArray, int Num) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawPixelSet_x86(PointDataArray, Num);
            } else {
                return dx_DrawPixelSet_x64(PointDataArray, Num);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawLineSet", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLineSet_x86([In, Out] LINEDATA[] LineDataArray, int Num);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawLineSet", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLineSet_x64([In, Out] LINEDATA[] LineDataArray, int Num);
        public static int DrawLineSet([In, Out] LINEDATA[] LineDataArray, int Num) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawLineSet_x86(LineDataArray, Num);
            } else {
                return dx_DrawLineSet_x64(LineDataArray, Num);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawPixel3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixel3D_x86(VECTOR Pos, uint Color);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawPixel3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixel3D_x64(VECTOR Pos, uint Color);
        public static int DrawPixel3D(VECTOR Pos, uint Color) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawPixel3D_x86(Pos, Color);
            } else {
                return dx_DrawPixel3D_x64(Pos, Color);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawPixel3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixel3DD_x86(VECTOR_D Pos, uint Color);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawPixel3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawPixel3DD_x64(VECTOR_D Pos, uint Color);
        public static int DrawPixel3DD(VECTOR_D Pos, uint Color) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawPixel3DD_x86(Pos, Color);
            } else {
                return dx_DrawPixel3DD_x64(Pos, Color);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawLine3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLine3D_x86(VECTOR Pos1, VECTOR Pos2, uint Color);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawLine3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLine3D_x64(VECTOR Pos1, VECTOR Pos2, uint Color);
        public static int DrawLine3D(VECTOR Pos1, VECTOR Pos2, uint Color) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawLine3D_x86(Pos1, Pos2, Color);
            } else {
                return dx_DrawLine3D_x64(Pos1, Pos2, Color);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawLine3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLine3DD_x86(VECTOR_D Pos1, VECTOR_D Pos2, uint Color);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawLine3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawLine3DD_x64(VECTOR_D Pos1, VECTOR_D Pos2, uint Color);
        public static int DrawLine3DD(VECTOR_D Pos1, VECTOR_D Pos2, uint Color) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawLine3DD_x86(Pos1, Pos2, Color);
            } else {
                return dx_DrawLine3DD_x64(Pos1, Pos2, Color);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawTriangle3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangle3D_x86(VECTOR Pos1, VECTOR Pos2, VECTOR Pos3, uint Color, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawTriangle3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangle3D_x64(VECTOR Pos1, VECTOR Pos2, VECTOR Pos3, uint Color, int FillFlag);
        public static int DrawTriangle3D(VECTOR Pos1, VECTOR Pos2, VECTOR Pos3, uint Color, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawTriangle3D_x86(Pos1, Pos2, Pos3, Color, FillFlag);
            } else {
                return dx_DrawTriangle3D_x64(Pos1, Pos2, Pos3, Color, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawTriangle3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangle3DD_x86(VECTOR_D Pos1, VECTOR_D Pos2, VECTOR_D Pos3, uint Color, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawTriangle3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawTriangle3DD_x64(VECTOR_D Pos1, VECTOR_D Pos2, VECTOR_D Pos3, uint Color, int FillFlag);
        public static int DrawTriangle3DD(VECTOR_D Pos1, VECTOR_D Pos2, VECTOR_D Pos3, uint Color, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawTriangle3DD_x86(Pos1, Pos2, Pos3, Color, FillFlag);
            } else {
                return dx_DrawTriangle3DD_x64(Pos1, Pos2, Pos3, Color, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCube3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCube3D_x86(VECTOR Pos1, VECTOR Pos2, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCube3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCube3D_x64(VECTOR Pos1, VECTOR Pos2, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawCube3D(VECTOR Pos1, VECTOR Pos2, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawCube3D_x86(Pos1, Pos2, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawCube3D_x64(Pos1, Pos2, DifColor, SpcColor, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCube3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCube3DD_x86(VECTOR_D Pos1, VECTOR_D Pos2, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCube3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCube3DD_x64(VECTOR_D Pos1, VECTOR_D Pos2, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawCube3DD(VECTOR_D Pos1, VECTOR_D Pos2, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawCube3DD_x86(Pos1, Pos2, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawCube3DD_x64(Pos1, Pos2, DifColor, SpcColor, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawSphere3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawSphere3D_x86(VECTOR CenterPos, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawSphere3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawSphere3D_x64(VECTOR CenterPos, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawSphere3D(VECTOR CenterPos, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawSphere3D_x86(CenterPos, r, DivNum, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawSphere3D_x64(CenterPos, r, DivNum, DifColor, SpcColor, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawSphere3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawSphere3DD_x86(VECTOR_D CenterPos, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawSphere3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawSphere3DD_x64(VECTOR_D CenterPos, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawSphere3DD(VECTOR_D CenterPos, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawSphere3DD_x86(CenterPos, r, DivNum, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawSphere3DD_x64(CenterPos, r, DivNum, DifColor, SpcColor, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCapsule3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCapsule3D_x86(VECTOR Pos1, VECTOR Pos2, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCapsule3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCapsule3D_x64(VECTOR Pos1, VECTOR Pos2, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawCapsule3D(VECTOR Pos1, VECTOR Pos2, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawCapsule3D_x86(Pos1, Pos2, r, DivNum, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawCapsule3D_x64(Pos1, Pos2, r, DivNum, DifColor, SpcColor, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCapsule3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCapsule3DD_x86(VECTOR_D Pos1, VECTOR_D Pos2, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCapsule3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCapsule3DD_x64(VECTOR_D Pos1, VECTOR_D Pos2, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawCapsule3DD(VECTOR_D Pos1, VECTOR_D Pos2, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawCapsule3DD_x86(Pos1, Pos2, r, DivNum, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawCapsule3DD_x64(Pos1, Pos2, r, DivNum, DifColor, SpcColor, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCone3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCone3D_x86(VECTOR TopPos, VECTOR BottomPos, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCone3D", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCone3D_x64(VECTOR TopPos, VECTOR BottomPos, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawCone3D(VECTOR TopPos, VECTOR BottomPos, float r, int DivNum, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawCone3D_x86(TopPos, BottomPos, r, DivNum, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawCone3D_x64(TopPos, BottomPos, r, DivNum, DifColor, SpcColor, FillFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_DrawCone3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCone3DD_x86(VECTOR_D TopPos, VECTOR_D BottomPos, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_DrawCone3DD", CharSet = CharSet.Unicode)]
        extern static int dx_DrawCone3DD_x64(VECTOR_D TopPos, VECTOR_D BottomPos, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag);
        public static int DrawCone3DD(VECTOR_D TopPos, VECTOR_D BottomPos, double r, int DivNum, uint DifColor, uint SpcColor, int FillFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_DrawCone3DD_x86(TopPos, BottomPos, r, DivNum, DifColor, SpcColor, FillFlag);
            } else {
                return dx_DrawCone3DD_x64(TopPos, BottomPos, r, DivNum, DifColor, SpcColor, FillFlag);
            }
        }
    }
}
