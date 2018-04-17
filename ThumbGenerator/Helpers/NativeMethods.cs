using System;
using System.Runtime.InteropServices;

namespace ThumbGenerator.Helpers
{
    public class NativeMethods
    {
        public const int WM_SETTEXT = 0x000c;
        public const uint WM_KEYDOWN = 0x0100;
        public const uint WM_KEYUP = 0x0101;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const string DLL_USER_IMPORT_NAME = "user32.dll";
        public const string DLL_GDI_IMPORT_NAME = "GDI32.dll";


        [DllImport(DLL_USER_IMPORT_NAME, EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(
            IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass,
            string lpszWindow);

        [DllImport(DLL_USER_IMPORT_NAME, SetLastError = true)]
        public static extern IntPtr PostMessage(
            IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport(DLL_USER_IMPORT_NAME)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport(DLL_USER_IMPORT_NAME)]
        public static extern bool ReleaseCapture();

        [DllImport(DLL_GDI_IMPORT_NAME)]
        public static extern bool BitBlt(
               int hdcDest, int nXDest, int nYDest, int nWidth,
               int nHeight, int hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport(DLL_GDI_IMPORT_NAME)]
        public static extern int CreateCompatibleBitmap(
            int hdc, int nWidth, int nHeight);

        [DllImport(DLL_GDI_IMPORT_NAME)]
        public static extern int CreateCompatibleDC(int hdc);

        [DllImport(DLL_GDI_IMPORT_NAME)]
        public static extern bool DeleteDC(int hdc);

        [DllImport(DLL_GDI_IMPORT_NAME)]
        public static extern bool DeleteObject(int hObject);

        [DllImport(DLL_GDI_IMPORT_NAME)]
        public static extern int CreateDC(string lpszDriver, string lpszDevice,
            string lpszOutput, IntPtr lpInitData);

        [DllImport(DLL_GDI_IMPORT_NAME)]
        public static extern int SelectObject(int hdc, int hgdiobj);
    }
}
