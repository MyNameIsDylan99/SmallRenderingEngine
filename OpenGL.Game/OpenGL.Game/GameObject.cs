using OpenGL.Game.Components;
using OpenGL.Mathematics;
using System.Collections.Generic;

namespace OpenGL.Game
{
    public class GameObject
    {
        public string Name { get; private set; }

        public Transform Transform { get; set; } = new Transform();

        public MeshRenderer Renderer { get; private set; }

        private List<Component> components = new List<Component>();

        public GameObject(string name, MeshRenderer renderer = null)
        {
            this.Renderer = renderer;
            this.Name = name;
        }

        public void Initialize()
        {
        }

        public void Update()
        {
            foreach (var component in components)
            {
                component.OnUpdate();
            }
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }

        public bool HasComponent<T>() where T : Component
        {
            return components.Exists((c)=>c.GetType() == typeof(T));
        }

        public T GetComponent<T>() where T : Component
        {
            return (T)components.Find((x) => x.GetType() == typeof(T));
        }
    }
}