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

        #endregion Methods
    }
}