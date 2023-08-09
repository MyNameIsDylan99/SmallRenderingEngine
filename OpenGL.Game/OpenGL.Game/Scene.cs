using OpenGL.Game.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL.Game
{
    public class Scene
    {

        #region Global Shader Parameters

        public bool EnableLighting = true;
        private bool useBlinn = false;

        private Vector3 directionalLight = new Vector3(0, -1, 0);
        private Vector3 directionalColor = new Vector3(0, 1, 0);
        private bool useDirectionalLight = false;

        //Global shader color
        public Vector3 Color = new Vector3(1, 1, 1);

        private float ambientIntensity = 0.3f;
        public Vector3 AmbientColor = new Vector3(0.75f, 0.75f, 1.0f);
        private float hardness = 64.0f;

        #endregion


        public Scene(Game game)
        {
            this.Game = game;
        }

        public Game Game { get; private set; }

        public Camera MainCamera;
        public List<GameObject> SceneGraph { get; private set; } = new List<GameObject>();


        public List<PointLight> PointLights = new List<PointLight>();

        public void Awake()
        {
            foreach (var go in SceneGraph)
            {
                go.Awake();
            }
        }

        public void Start()
        {
            foreach (var go in SceneGraph)
            {
                go.Start();
            }
        }

        public void Disable()
        {
            foreach (var go in SceneGraph)
            {
                go.Disable();
            }
        }
        public void Render()
        {
            if (MainCamera == null)
            {
                Console.WriteLine("There is no main camera. Please set a main camera for the scene before calling Render()");
                return;
            }

            foreach (var go in SceneGraph)
            {
                if (go.Renderer == null)
                    continue;

                SetUniforms(go);
                go.Renderer.Render();
            }
        }
        public void Update()
        {
            foreach (var go in SceneGraph)
            {
                go.Update();
            }
        }

        private void SetUniforms(GameObject obj)
        {
            //Tranformation matrices

            //For some reason I have to use SRT matrix to apply all transformation in local space.
            Matrix4 model = obj.Transform.GetSRT();
            Matrix4 view = MainCamera.GetViewMatrix();
            Matrix4 projection = MainCamera.GetProjectionMatrix();

            Matrix4 tangentToWorld = model.Inverse().Transpose();


            //TODO: Add support for multiple point lights

            var lightData = GetLightDataMatrix();

            //--------------------------
            // Data passing to shader
            //--------------------------

            ShaderProgram material = obj.Renderer.Material;
            material.Use();

            //TODO: Use more matrices to pass data to shader

            material["model"]?.SetValue(model);
            material["projection"]?.SetValue(projection);
            material["view"]?.SetValue(view);
            material["color"]?.SetValue(Color);
            material["enableLighting"]?.SetValue(EnableLighting);
            material["tangentToWorld"]?.SetValue(tangentToWorld);
            material["lightData"]?.SetValue(lightData);
            material["directionalLight"]?.SetValue(directionalLight);
            material["directionalColor"]?.SetValue(directionalColor);
            material["useDirectional"]?.SetValue(useDirectionalLight);
            material["useBlinn"]?.SetValue(useBlinn);
            material["cameraPos"]?.SetValue(MainCamera.Transform.Position);
            material["lightColor"]?.SetValue(obj.GetComponent<PointLight>().lightColor);
        }

        public void ToggleLightingCallback(bool isLPressed)
        {
            if (isLPressed)
            {
                ToggleLighting();
            }
        }

        public void ToggleLighting()
        {
            EnableLighting = !EnableLighting;

            if (EnableLighting)
                Game.UserInterfaceHelper.lightingOnText.String = "Lighting on";
            else
                Game.UserInterfaceHelper.lightingOnText.String = "Lighting off";
        }

        public void ToggleDirectionalLighting()
        {
            useDirectionalLight = !useDirectionalLight;
        }

        public void ToggleBlinnLighting()
        {
            useBlinn = !useBlinn;

            if (useBlinn)
                Game.UserInterfaceHelper.useBlinnText.String = "Using Blinn";
            else
                Game.UserInterfaceHelper.useBlinnText.String = "Using Phong";
        }
        private Matrix4 GetLightDataMatrix()
        {
            Matrix4 lightDataMatrix = new Matrix4();

            foreach (var light in PointLights)
            {
                lightDataMatrix.SetMatrix
                    (
                    new Vector4(light.Transform.Position, ambientIntensity),
                    new Vector4(AmbientColor, light.diffuseIntensity),
                    new Vector4(light.lightColor, light.specularIntensity),
                    new Vector4(MainCamera.Transform.Position, hardness)
                    );
            }
            return lightDataMatrix;
        }

    }
}
