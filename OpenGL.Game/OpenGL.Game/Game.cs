using OpenGL.Mathematics;
using OpenGL.Platform;
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

        #region Camera Parameters

        private float movementSpeed = 3.0f;
        private float rotationSpeed = 5.0f;
        public float MovementSpeed { get => movementSpeed; set => movementSpeed = value; }
        public float RotationSpeed { get => rotationSpeed; set => rotationSpeed = value; }

        private Vector3 cameraPos = Vector3.Zero;
        private Vector3 cameraRotation = Vector3.Zero;
        public Vector3 CameraPos { get => cameraPos; set => cameraPos = value; }
        public Vector3 CameraRotation { get => cameraRotation; set => cameraRotation = value; }

        #endregion Camera Parameters

        public List<GameObject> SceneGraph { get; private set; } = new List<GameObject>();

        public Game()
        {
        }

        public void Render()
        {
            foreach (var go in SceneGraph)
            {
                SetTransform(go);
                go.Renderer.Render();
            }
        }

        public void Update()
        {
        }

        #region Transformation

        private void SetTransform(GameObject obj)
        {
            Matrix4 view = GetViewMatrix();
            Matrix4 projection = GetProjectionMatrix();
            Matrix4 model = obj.Transform.GetSRT();
            Matrix4 tangentToWorld = model.Inverse().Transpose();

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
            if (obj.Name != "Light source")
                material["tangentToWorld"].SetValue(tangentToWorld);
        }

        private Matrix4 GetViewMatrix()
        {
            Matrix4 viewTranslation = Matrix4.Identity;
            Matrix4 viewRotation = Matrix4.Identity;
            Matrix4 viewScale = Matrix4.Identity;

            viewTranslation = Matrix4.CreateTranslation(CameraPos);
            Matrix4 viewRotationX = Matrix4.CreateRotation(new Vector3(1.0f, 0.0f, 0.0f), Mathf.ToRad(-CameraRotation.X));
            Matrix4 viewRotationY = Matrix4.CreateRotation(new Vector3(0.0f, 1.0f, 0.0f), Mathf.ToRad(-CameraRotation.Y));
            Matrix4 viewRotationZ = Matrix4.CreateRotation(new Vector3(0.0f, 0.0f, 1.0f), Mathf.ToRad(-CameraRotation.Z));

            viewRotation = viewRotationY * viewRotationX;

            viewScale = Matrix4.CreateScaling(new Vector3(1.0f, 1.0f, 1.0f));

            Matrix4 view = viewTranslation * viewRotation * viewScale;// TRS matrix -> scale, rotate then translate -> All applied in LOCAL Coordinates

            return view;
        }

        private Matrix4 GetProjectionMatrix()
        {
            float fov = 45;

            float aspectRatio = (float)Width / (float)Height;
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(Mathf.ToRad(fov), (float)Width / Height, 0.1f, 1000f);
            //Matrix4 projection = Matrix4.CreateOrthographic(1, 1, 0.1f, 100.0f);

            return projection;
        }

        #endregion Transformation

        #region Camera

        private Vector3 GetForwardAxis()
        {
            var forward = new Vector3(0, 0, 1);

            //forward.x =  cos(pitch) * sin(yaw);
            //forward.y = -sin(pitch);
            //forward.z =  cos(pitch) * cos(yaw);

            var pitch = Mathf.ToRad(CameraRotation.X);
            var yaw = Mathf.ToRad(CameraRotation.Y);

            forward.X = (float)-(Math.Cos(pitch) * Math.Sin(yaw));
            forward.Y = (float)(Math.Sin(pitch));
            forward.Z = (float)(Math.Cos(pitch) * Math.Cos(yaw));

            return forward.Normalize();
        }

        private Vector3 GetUpAxis()
        {
            //up.x = sin(pitch) * sin(yaw);
            //up.y = cos(pitch);
            //up.z = sin(pitch) * cos(yaw);

            var up = new Vector3(0, 1, 0);

            var pitch = Mathf.ToRad(CameraRotation.X);
            var yaw = Mathf.ToRad(CameraRotation.Y);

            up.X = (float)-(Math.Sin(pitch) * Math.Sin(yaw));
            up.Y = (float)-(Math.Cos(pitch));
            up.Z = (float)(Math.Sin(pitch) * Math.Cos(yaw));

            return up.Normalize();
        }

        private Vector3 GetRightAxis()
        {
            //right.x =  cos(yaw);
            //right.y =  0;
            //right.z = -sin(yaw);

            var right = new Vector3(1, 0, 0);

            var yaw = Mathf.ToRad(CameraRotation.Y);

            right.X = (float)(-Math.Cos(yaw));
            right.Y = 0;
            right.Z = (float)(-Math.Sin(yaw));

            return right.Normalize();
        }

        #region Camera Movement

        public void ProcessForwardMovement()
        {
            CameraPos += GetForwardAxis() * Time.DeltaTime * MovementSpeed;
        }

        public void ProcessBackwardsMovement()
        {
            CameraPos += -GetForwardAxis() * Time.DeltaTime * MovementSpeed;
        }

        public void ProcessLeftMovement()
        {
            CameraPos += -GetRightAxis() * Time.DeltaTime * MovementSpeed;
        }

        public void ProcessRightMovement()
        {
            CameraPos += GetRightAxis() * Time.DeltaTime * MovementSpeed;
        }

        public void ProcessUpMovement()
        {
            CameraPos += GetUpAxis() * Time.DeltaTime * MovementSpeed;
        }

        public void ProcessDownMovement()
        {
            CameraPos += -GetUpAxis() * Time.DeltaTime * MovementSpeed;
        }

        #endregion Camera Movement

        #endregion Camera
    }
}