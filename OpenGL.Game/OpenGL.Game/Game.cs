using OpenGL.Game.Components;
using System;
using System.Collections.Generic;

namespace OpenGL.Game
{
    public class Game
    {
        #region Window Parameters

        private int width = 800;
        private int height = 500;
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        #endregion Window Parameters

        public UserInterfaceHelper UserInterfaceHelper;

        private Vector3 directionalLight = new Vector3(0, -1, 0);
        private Vector3 directionalColor = new Vector3(0, 1, 0);
        private bool useDirectionalLight = false;

        public bool EnableLighting = true;

        //Global shader color
        public Vector3 Color = new Vector3(1, 1, 1);

        public Camera MainCamera;

        public List<PointLight> PointLights = new List<PointLight>();
        public List<GameObject> SceneGraph { get; private set; } = new List<GameObject>();

        public Game(UserInterfaceHelper userInterfaceHelper)
        {
            this.UserInterfaceHelper = userInterfaceHelper;
        }

        private float ambientIntensity = 0.3f;
        private Vector3 ambientColor = new Vector3(0.75f, 0.75f, 1.0f);
        private float hardness = 64.0f;

        private Matrix4 GetLightDataMatrix()
        {
            Matrix4 lightDataMatrix = new Matrix4();

            foreach (var light in PointLights)
            {
                lightDataMatrix.SetMatrix
                    (
                    new Vector4(light.Transform.Position, ambientIntensity),
                    new Vector4(ambientColor, light.diffuseIntensity),
                    new Vector4(light.lightColor, light.specularIntensity),
                    new Vector4(MainCamera.Transform.Position, hardness)
                    );
            }
            return lightDataMatrix;
        }

        public void Render()
        {
            if (MainCamera == null)
            {
                Console.WriteLine("There is no main camera. Please set a main camera for the game before calling Render()");
                return;
            }

            foreach (var go in SceneGraph)
            {
                if (go.Renderer == null)
                    return;

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
            Matrix4 view = MainCamera.GetViewMatrix();
            Matrix4 projection = MainCamera.GetProjectionMatrix();
            Matrix4 model = obj.Transform.GetSRT();
            Matrix4 tangentToWorld = model.Inverse().Transpose();

            ////Light data
            //List<Matrix3> lightDatas = new List<Matrix3>();
            //foreach (var light in PointLights)
            //{
            //    lightDatas.Add(light.GetLightData());
            //}

            var lightData = GetLightDataMatrix();

            //--------------------------
            // Data passing to shader
            //--------------------------

            ShaderProgram material = obj.Renderer.Material;
            material.Use();

            material["projection"].SetValue(projection);
            material["view"].SetValue(view);

            //Since we have row based vectors we need the SRT matrix to apply all transformations in local space
            material["model"].SetValue(model);

            //Since the light object has a different shader that doesn't have a tangent to world uniform, we won't pass it to the light source
            if (!obj.HasComponent<PointLight>())
            {
                material["color"].SetValue(Color);
                material["enableLighting"].SetValue(EnableLighting);
                material["tangentToWorld"].SetValue(tangentToWorld);
                material["lightData"].SetValue(lightData);
                material["directionalLight"].SetValue(directionalLight);
                material["directionalColor"].SetValue(directionalColor);
                material["useDirectional"].SetValue(useDirectionalLight);
            }
            else
            {
                material["lightColor"].SetValue(obj.GetComponent<PointLight>().lightColor);
            }
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
                UserInterfaceHelper.lightingOnText.String = "Lighting on";
            else
                UserInterfaceHelper.lightingOnText.String = "Lighting off";
        }

        public void ToggleDirectionalLighting()
        {
            useDirectionalLight = !useDirectionalLight;
        }
    }
}