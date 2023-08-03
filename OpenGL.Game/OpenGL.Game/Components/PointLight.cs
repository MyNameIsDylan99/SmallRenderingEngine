namespace OpenGL.Game.Components
{
    public class PointLight : Component
    {
        public Vector3 lightColor = new Vector3(1.0f, 0.75f, 0.0f);
        public float diffuseIntensity = 1f;
        public float specularIntensity = 1f;

        public PointLight(GameObject gameObject) : base(gameObject)
        {
        }

        public override void OnUpdate()
        {
        }

        public Matrix3 GetLightData()
        {
            Matrix3 lightMatrix = new Matrix3();
            lightMatrix.SetMatrix(transform.Position, lightColor, new Vector3(diffuseIntensity, specularIntensity, 0));
            return lightMatrix;
        }
    }
}