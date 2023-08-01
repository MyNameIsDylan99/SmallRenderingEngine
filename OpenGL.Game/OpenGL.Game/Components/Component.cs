using OpenGL.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL.Game.Components
{
    public abstract class Component
    {
        protected GameObject gameObject;
        public GameObject GameObject { get => gameObject; private set => gameObject = value; }

        protected Transform transform;
        public Transform Transform { get => transform; private set => transform = value; }

        public Component(GameObject gameObject = null)
        {
            if (gameObject == null) return;
            SetGameObject(gameObject);
        }

        public abstract void OnUpdate();

        public void SetGameObject(GameObject gameObject)
        {
            GameObject = gameObject;
            transform = gameObject.Transform;
            gameObject.AddComponent(this);
        }

    }
}
