using System;

namespace OpenGL.Mathematics
{
    public class Transform
    {
        #region Properties

        public Vector3 Position
        {
            get;
            set;
        } = Vector3.Zero;
        public Vector3 Forward
        {
            get => GetForwardAxis();
        }
        public Vector3 Right
        {
            get => GetRightAxis();
        }
        public Vector3 Up
        {
            get => GetUpAxis();
        }

        public Vector3 Scale
        {
            get;
            set;
        } = Vector3.One;

        public Vector3 Rotation
        {
            get;
            set;
        } = Vector3.Zero;

        #endregion Properties

        #region Methods

        public Matrix4 GetTRS()
        {
            //model Translation
            Matrix4 modelTranslation = Matrix4.CreateTranslation(Position);

            //model rotation
            Matrix4 modelRotationX = Matrix4.CreateRotation(new Vector3(1.0f, 0.0f, 0.0f),
            Mathf.ToRad(Rotation.X));
            Matrix4 modelRotationY = Matrix4.CreateRotation(new Vector3(0.0f, 1.0f, 0.0f),
            Mathf.ToRad(Rotation.Y));
            Matrix4 modelRotationZ = Matrix4.CreateRotation(new Vector3(0.0f, 0.0f, 1.0f),
            Mathf.ToRad(Rotation.Z));
            Matrix4 modelRotation = modelRotationX * modelRotationY * modelRotationZ;

            //model Scale
            Matrix4 modelScale = Matrix4.CreateScaling(Scale);

            Matrix4 model = modelTranslation * modelRotation * modelScale; // Compose TRS matr

            return model;
        }
        public Matrix4 GetSRT()
        {
            //model Translation
            Matrix4 modelTranslation = Matrix4.CreateTranslation(Position);

            //model rotation
            Matrix4 modelRotationX = Matrix4.CreateRotation(new Vector3(1.0f, 0.0f, 0.0f),
            Mathf.ToRad(Rotation.X));
            Matrix4 modelRotationY = Matrix4.CreateRotation(new Vector3(0.0f, 1.0f, 0.0f),
            Mathf.ToRad(Rotation.Y));
            Matrix4 modelRotationZ = Matrix4.CreateRotation(new Vector3(0.0f, 0.0f, 1.0f),
            Mathf.ToRad(Rotation.Z));
            Matrix4 modelRotation = modelRotationX * modelRotationY * modelRotationZ;

            //model Scale
            Matrix4 modelScale = Matrix4.CreateScaling(Scale);

            Matrix4 model = modelScale * modelRotation * modelTranslation; // Compose SRT matr

            return model;
        }
        private Vector3 GetForwardAxis()
        {
            var forward = new Vector3(0, 0, 1);

            //forward.x =  cos(pitch) * sin(yaw);
            //forward.y = -sin(pitch);
            //forward.z =  cos(pitch) * cos(yaw);

            var pitch = Mathf.ToRad(Rotation.X);
            var yaw = Mathf.ToRad(Rotation.Y);

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

            var pitch = Mathf.ToRad(Rotation.X);
            var yaw = Mathf.ToRad(Rotation.Y);

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

            var yaw = Mathf.ToRad(Rotation.Y);

            right.X = (float)(-Math.Cos(yaw));
            right.Y = 0;
            right.Z = (float)(-Math.Sin(yaw));

            return right.Normalize();
        }

        #endregion Methods
    }
}