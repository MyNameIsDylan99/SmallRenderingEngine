namespace SAE.OpenGL.S1.Utility
{
using System;
using System.Runtime.InteropServices;

    /// <summary>
    /// Helper class to restrict the cursor movement
    /// </summary>
public class CursorRestriction
{
    [DllImport("user32.dll")]
    public static extern bool ClipCursor(ref RECT lpRect);

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

        /// <summary>
        /// Restricts the cursor movement to a defined rectangle. Rectangle coordinates in screen space. Top left is x = 0, y = 0.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
    public static void RestrictCursorToRectangle(int left, int top, int right, int bottom)
    {
        RECT rect = new RECT { Left = left, Top = top, Right = right, Bottom = bottom };
        ClipCursor(ref rect);
    }

    public static void ReleaseCursor()
    {
            RECT rect = new RECT();
        ClipCursor(ref rect); // Resets the cursor restriction
    }
}
}
