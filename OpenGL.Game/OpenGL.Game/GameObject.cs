using OpenGL.Mathematics;

namespace OpenGL.Game
{
    public class GameObject
    {
        public string Name { get; private set; }

        public Transform Transform { get; set; } = new Transform();

        public MeshRenderer Renderer { get; private set; }

        public GameObject(string name, MeshRenderer renderer)
        {
            this.Renderer = renderer;
            this.Name = name;
        }

        public void Initialize()
        {

        }

        public void Update()
        {

        }
    }
}