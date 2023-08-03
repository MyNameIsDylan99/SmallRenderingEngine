using OpenGL.Platform;
using System.Runtime.InteropServices;

/// <summary>
/// Helper class to restrict the cursor movement
/// </summary>
public static class CursorRestriction
{
    public static bool IsCursorRestricted { get; private set; } = true;

    [DllImport("user32.dll")]
    public static extern bool ClipCursor(ref RECT lpRect);

    [DllImport("user32.dll")]
    private static extern int GetSystemMetrics(int nIndex);

    private const int SM_XVIRTUALSCREEN = 76;
    private const int SM_YVIRTUALSCREEN = 77;
    private const int SM_CXVIRTUALSCREEN = 78;
    private const int SM_CYVIRTUALSCREEN = 79;

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
        RECT rect = new RECT() { Left = GetSystemMetrics(SM_XVIRTUALSCREEN), Right = GetSystemMetrics(SM_CXVIRTUALSCREEN), Top = GetSystemMetrics(SM_YVIRTUALSCREEN), Bottom = GetSystemMetrics(SM_CYVIRTUALSCREEN) };
        ClipCursor(ref rect); // Resets the cursor restriction
    }

    public static void OnEscapeChanged(bool isPressed)
    {
        if (isPressed)
        {
            if (IsCursorRestricted)
            {
                CursorRestriction.ReleaseCursor();
                Window.ShowCursor(true);
            }
            else
            {
                var windowPosition = Window.GetWindowPosition();
                CursorRestriction.RestrictCursorToRectangle((int)windowPosition.X, (int)windowPosition.Y, (int)windowPosition.X + Window.Width, (int)windowPosition.Y + Window.Height);
                Window.ShowCursor(false);
            }

            IsCursorRestricted = !IsCursorRestricted;
        }
    }

    public static void OnMouseMove(int lx, int ly, int x, int y)
    {
        if (!IsCursorRestricted) return;

        var moveDeltaX = x - lx;
        var moveDeltaY = y - ly;

        int maxDeltaX = (int)(Window.Width * 0.9);
        int maxDeltaY = ((int)(Window.Height * 0.9));

        if (moveDeltaX > maxDeltaX || moveDeltaY > maxDeltaY || moveDeltaX < -maxDeltaX || moveDeltaY < -maxDeltaY)
            return;

        if (x == Window.Width - 1)
            Window.WarpPointer(1, y);

        if (x == 0)
            Window.WarpPointer(Window.Width - 2, y);

        if (y == Window.Height - 1)
            Window.WarpPointer(x, 1);

        if (y == 0)
            Window.WarpPointer(x, Window.Height - 2);
    }
}