using OpenGL.Platform;
using System;

public static class InputHelper
{
    #region Delegates and Events

    public static event Action<bool> ButtonWPressedEvent;

    public static event Action<bool> ButtonAPressedEvent;

    public static event Action<bool> ButtonSPressedEvent;

    public static event Action<bool> ButtonDPressedEvent;

    public static event Action<bool> ButtonQPressedEvent;

    public static event Action<bool> ButtonEPressedEvent;

    public static event Action<bool> ButtonLPressedEvent;

    public static event Action<bool> ButtonEscapePressedEvent;

    public static event Action<bool> ButtonSpacePressedEvent;

    public static event Action<bool> ButtonUpArrowPressedEvent;

    public static event Action<bool> ButtonDownArrowPressedEvent;

    public static event Action<bool> ButtonLeftArrowPressedEvent;

    public static event Action<bool> ButtonRightArrowPressedEvent;

    /// <summary>
    /// This event contains the moveDelta of the x and y axis of the mouse movement and is only called if CursorRestriction.IsCursorRestricted equals true ;
    /// </summary>
    public static event Action<int, int> MouseMoveEvent;

    /// <summary>
    /// This event contains the x and y positions of the cursor last frame and of the current frame and is always called.
    /// </summary>
    public static event Action<int, int, int, int> MouseMoveEventFullSignature;

    #endregion Delegates and Events

    #region Key States

    private static bool isWPressed = false;
    private static bool isSPressed = false;
    private static bool isAPressed = false;
    private static bool isDPressed = false;
    private static bool isEPressed = false;
    private static bool isQPressed = false;
    private static bool isLPressed = false;
    private static bool isSpacePressed = false;

    private static bool isUpPressed = false;
    private static bool isDownPressed = false;
    private static bool isLeftPressed = false;
    private static bool isRightPressed = false;

    public static bool IsWPressed { get => isWPressed; private set => isWPressed = value; }
    public static bool IsSPressed { get => isSPressed; private set => isSPressed = value; }
    public static bool IsAPressed { get => isAPressed; private set => isAPressed = value; }
    public static bool IsDPressed { get => isDPressed; private set => isDPressed = value; }
    public static bool IsEPressed { get => isEPressed; private set => isEPressed = value; }
    public static bool IsQPressed { get => isQPressed; private set => isQPressed = value; }
    public static bool IsLPressed { get => isLPressed; private set => isLPressed = value; }
    public static bool IsSpacePressed { get => isSpacePressed; private set => isSpacePressed = value; }
    public static bool IsUpPressed { get => isUpPressed; private set => isUpPressed = value; }
    public static bool IsDownPressed { get => isDownPressed; private set => isDownPressed = value; }
    public static bool IsLeftPressed { get => isLeftPressed; private set => isLeftPressed = value; }
    public static bool IsRightPressed { get => isRightPressed; private set => isRightPressed = value; }

    #endregion Key States

    public static void InitInputs()
    {
        // Hook to the escape press event using the OpenGL.UI class library
        Input.Subscribe('w', new Event(OnWChanged));
        Input.Subscribe('s', new Event(OnSChanged));
        Input.Subscribe('a', new Event(OnAChanged));
        Input.Subscribe('d', new Event(OnDChanged));
        Input.Subscribe('e', new Event(OnEChanged));
        Input.Subscribe('q', new Event(OnQChanged));
        Input.Subscribe('l', new Event(OnLChanged));
        Input.Subscribe((char)0, new Event(OnLeftChanged));
        Input.Subscribe((char)1, new Event(OnRightChanged));
        Input.Subscribe((char)2, new Event(OnUpChanged));
        Input.Subscribe((char)3, new Event(OnDownChanged));
        Input.Subscribe((char)ConsoleKey.Spacebar, new Event(OnSpaceChanged));

        Input.Subscribe((char)27, new Event(OnEscapeChanged));
        ButtonEscapePressedEvent += CursorRestriction.OnEscapeChanged;

        Input.MouseMove = new Event(MouseMove);
        MouseMoveEventFullSignature += CursorRestriction.OnMouseMove;
    }

    private static void OnWChanged(bool isPressed)
    {
        IsWPressed = isPressed;

        if (ButtonWPressedEvent != null)
            ButtonWPressedEvent(isPressed);
    }

    private static void OnSChanged(bool isPressed)
    {
        IsSPressed = isPressed;
        if (ButtonSPressedEvent != null)
            ButtonSPressedEvent(isPressed);
    }

    private static void OnAChanged(bool isPressed)
    {
        IsAPressed = isPressed;

        if (ButtonAPressedEvent != null)
            ButtonAPressedEvent(isPressed);
    }

    private static void OnDChanged(bool isPressed)
    {
        IsDPressed = isPressed;

        if (ButtonDPressedEvent != null)
            ButtonDPressedEvent(isPressed);
    }

    private static void OnEChanged(bool isPressed)
    {
        IsEPressed = isPressed;

        if (ButtonEPressedEvent != null)
            ButtonEPressedEvent(isPressed);
    }

    private static void OnQChanged(bool isPressed)
    {
        IsQPressed = isPressed;

        if (ButtonQPressedEvent != null)
            ButtonQPressedEvent(isPressed);
    }

    private static void OnLChanged(bool isPressed)
    {
        IsLPressed = isPressed;

        if (ButtonLPressedEvent != null)
            ButtonLPressedEvent(isPressed);
    }

    private static void OnSpaceChanged(bool isPressed)
    {
        IsSpacePressed = isPressed;

        if (ButtonSpacePressedEvent != null)
        {
            ButtonSpacePressedEvent(isPressed);
        }
    }

    private static void OnEscapeChanged(bool isPressed)
    {
        if (ButtonEscapePressedEvent != null)
            ButtonEscapePressedEvent(isPressed);
    }

    private static void OnUpChanged(bool isPressed)
    {
        IsUpPressed = isPressed;

        if (ButtonUpArrowPressedEvent != null)
            ButtonUpArrowPressedEvent(isPressed);
    }

    private static void OnDownChanged(bool isPressed)
    {
        IsDownPressed = isPressed;

        if (ButtonDownArrowPressedEvent != null)
            ButtonDownArrowPressedEvent(isPressed);
    }

    private static void OnLeftChanged(bool isPressed)
    {
        IsLeftPressed = isPressed;

        if (ButtonLeftArrowPressedEvent != null)
            ButtonLeftArrowPressedEvent(isPressed);
    }

    private static void OnRightChanged(bool isPressed)
    {
        IsRightPressed = isPressed;

        if (ButtonRightArrowPressedEvent != null)
            ButtonRightArrowPressedEvent(isPressed);
    }

    private static void MouseMove(int lx, int ly, int x, int y)
    {
        if (MouseMoveEventFullSignature != null)
            MouseMoveEventFullSignature(lx, ly, x, y);

        if (!CursorRestriction.IsCursorRestricted) return;

        var moveDeltaX = x - lx;
        var moveDeltaY = y - ly;

        int maxDeltaX = (int)(Window.Width * 0.9);
        int maxDeltaY = ((int)(Window.Height * 0.9));

        if (moveDeltaX > maxDeltaX || moveDeltaY > maxDeltaY || moveDeltaX < -maxDeltaX || moveDeltaY < -maxDeltaY)
            return;

        if (MouseMoveEvent != null)
            MouseMoveEvent(moveDeltaX, moveDeltaY);
    }
}