using OpenGL.Game.Components;
using System;
using System.Collections.Generic;

namespace OpenGL.Game
{
    public class Game
    {
        #region Window Parameters

        private int width = 1000;
        private int height = 800;
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        #endregion Window Parameters

        public UserInterfaceHelper UserInterfaceHelper;

        public int CurrentSceneIndex = 0;
        public List<Scene> Scenes = new List<Scene>();
        public Scene MainScene;

        public bool IsInitalized = false;

        public Game(UserInterfaceHelper userInterfaceHelper)
        {
            this.UserInterfaceHelper = userInterfaceHelper;
        }

        public void Initalize()
        {
            Awake();
            Start();
            IsInitalized=true;
        }

        public void Awake()
        {
            if(MainScene == null)
            {
                Console.WriteLine("There is no main scene. Please set a mainScene before calling awake");
                return;
            }

            CurrentSceneIndex = Scenes.IndexOf(MainScene);
            MainScene.Awake();
        }

        public void Start()
        {
            if(MainScene == null)
            {
                Console.WriteLine("There is no main scene. Please set a mainScene before calling start");
                return;
            }

            MainScene.Start();
        }

        public void DisableScene(Scene scene)
        {
            scene.Disable();
        }

        public void Render()
        {
            if (!IsInitalized)
            {
                Console.WriteLine("Game isn't initalized. Please call Initalize() first.");
                return;
            }

            MainScene.Render();
        }

        public void Update()
        {
            if (!IsInitalized)
            {
                Console.WriteLine("Game isn't initalized. Please call Initalize() first.");
                return;
            }

            MainScene.Update();
        }


        public void ToggleLightingCallback(bool isLPressed)
        {
            if (isLPressed)
            {
                MainScene.ToggleLighting();
            }
        }
        public void ToggleDirectionalLighting()
        {
            MainScene.ToggleDirectionalLighting();
        }

        public void ToggleBlinnLighting()
        {
            MainScene.ToggleBlinnLighting();
        }

        public void MakeNextSceneActive()
        {
            DisableScene(MainScene);

            CurrentSceneIndex++;
            CurrentSceneIndex = CurrentSceneIndex % Scenes.Count;
            MainScene = Scenes[CurrentSceneIndex];

            Initalize();
        }
        public void MakeSceneActive(Scene scene)
        {
            DisableScene(MainScene);

            MainScene  = scene;
            CurrentSceneIndex = Scenes.IndexOf(scene);

            Initalize();
        }
    }
}