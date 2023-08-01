using System.Collections.Generic;

namespace OpenGL.Game.Components
{
    public class MeshRenderer : Component
    {
        public VAO Geometry { get; private set; }
        public ShaderProgram Material { get; private set; }

        public List<Texture> MeshTextures { get; private set; } = new List<Texture>();

        public MeshRenderer(ShaderProgram material, VAO geometry, List<Texture> textures = null ,GameObject gameObject = null) : base(gameObject)
        {
            Material = material;
            Geometry = geometry;

            if (textures != null)
                MeshTextures = textures;
        }

        public void Render()
        {
            for (int i = 0; i < MeshTextures.Count; i++)
            {
                Gl.BindTextureUnit((uint)i, MeshTextures[i].TextureID);
            }

            Geometry.Program.Use();
            Geometry.Draw();
        }

        public override void OnUpdate()
        {
        }
    }
}