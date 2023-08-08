using OpenGL.Game.Components;
using OpenGL.Mathematics;
using System;
using System.Collections.Generic;

namespace OpenGL.Game
{
    public class GameObject
    {
        public string Name { get; private set; }

        public Transform Transform { get; set; } = new Transform();

        public Game game;

        public MeshRenderer Renderer { get; private set; }

        private List<Component> components = new List<Component>();

        public GameObject(string name, Game game, MeshRenderer renderer = null)
        {
            AddComponent(renderer);
            //this.Renderer = renderer;
            //renderer.AttachToGameObject(this);

            this.Name = name;
            this.game = game;
        }

        public void Initialize()
        {
        }

        public void Start()
        {
            foreach (var component in components)
            {
                component.OnStart();
            }
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
            if (component == null)
                return;

            if(component.GetType() == typeof(MeshRenderer))
            {
                this.Renderer = component as MeshRenderer;
            }

            component.AttachToGameObject(this);
            components.Add(component);
        }

        public bool HasComponent<T>() where T : Component
        {
            return components.Exists((c) => c.GetType() == typeof(T));
        }

        public T GetComponent<T>() where T : Component
        {
            return (T)components.Find((x) => x.GetType() == typeof(T));
        }
    }
}