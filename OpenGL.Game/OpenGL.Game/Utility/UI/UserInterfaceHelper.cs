using OpenGL;
using OpenGL.UI;

public static class UserInterfaceHelper
{
    public static Text topLeftText;
    public static Text lightingOnText;

    public static void SetupUI(int width, int height)
    {
        OpenGL.UI.UserInterface.InitUI(width, height);

        // create some centered text
        topLeftText = new OpenGL.UI.Text(OpenGL.UI.Text.FontSize._24pt,
            "SAE S1 - Demo", OpenGL.UI.BMFont.Justification.Center);
        topLeftText.RelativeTo = OpenGL.UI.Corner.TopLeft;
        topLeftText.Position = new Point(50, 50);

        lightingOnText = new OpenGL.UI.Text(OpenGL.UI.Text.FontSize._24pt,
            "Lighting on", OpenGL.UI.BMFont.Justification.Center);
        lightingOnText.RelativeTo = Corner.TopRight;
        lightingOnText.Position = new Point(100, 50);

        var buttonTexture = new Texture("ui/button.png");
        var button = new OpenGL.UI.Button(buttonTexture);
        button.Size = new Point(100, 50);
        button.RelativeTo = OpenGL.UI.Corner.TopLeft;
        button.Position = new Point(50, 50);

        // add the two text object to the UI
        //OpenGL.UI.UserInterface.AddElement(topLeftText);
        //OpenGL.UI.UserInterface.AddElement(lightingOnText);
        OpenGL.UI.UserInterface.AddElement(button);
    }

    public static void ToggleLightingOnText(bool isOn)
    {
        if (isOn)
            lightingOnText.String = "Lighting on";
        else
            lightingOnText.String = "Lighting off";
    }
}