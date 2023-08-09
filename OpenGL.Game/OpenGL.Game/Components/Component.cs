using System;
using OpenGL.Mathematics;

namespace OpenGL.Game.Components
{
    public abstract class Component
    {
        protected GameObject gameObject;
        public GameObject GameObject { get => gameObject; private set => gameObject = value; }

        protected Transform transform;
        public Transform Transform { get => transform; private set => transform = value; }

        public Component()
        {
        }
        public abstract void OnAwake();

        public abstract void OnStart();

        public abstract void OnUpdate();

        public abstract void OnDisable();


        public void AttachToGameObject(GameObject gameObject)
        {
            if(this.gameObject != null)
            {
                Console.WriteLine("Component of type: " + this.GetType().ToString() + " could not be attached to gameObject: " + gameObject.Name + " because it is currently attached to: " + GameObject.Name + ".");
                Console.WriteLine("A component can only be added to one gameObject at a time");
                return;
            }

            GameObject = gameObject;
            transform = gameObject.Transform;
        }
    }
}