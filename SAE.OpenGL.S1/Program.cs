using ObjLoader.Loader.Data.VertexData;
using ObjLoader.Loader.Loaders;
using OpenGL;
using OpenGL.Game;
using OpenGL.Game.Components;
using OpenGL.Platform;
using static OpenGL.GenericVAO;

namespace SAEOpenGL.S1
{
    internal static class Program
    {
        private static Game game;
        private static UserInterfaceHelper userInterfaceHelper = new UserInterfaceHelper();

        private static int Width { get => game.Width; set => game.Width = value; }
        private static int Height { get => game.Height; set => game.Height = value; }

        #region Skybox

    private static Vector3[] skyboxVertices = new Vector3[]
        {
    // Front face
    new Vector3(-1.0f, -1.0f, -1.0f),
    new Vector3(-1.0f,  1.0f, -1.0f),
    new Vector3( 1.0f,  1.0f, -1.0f),
    new Vector3( 1.0f, -1.0f, -1.0f),

    // Back face
    new Vector3(-1.0f, -1.0f,  1.0f),
    new Vector3(-1.0f,  1.0f,  1.0f),
    new Vector3( 1.0f,  1.0f,  1.0f),
    new Vector3( 1.0f, -1.0f,  1.0f)
        };

        private static uint[] skyboxIndices = new uint[]
        {
    // Front face
    0, 1, 2,
    2, 3, 0,

    // Back face
    5, 4, 7,
    7, 6, 5,

    // Left face
    4, 0, 3,
    3, 7, 4,

    // Right face
    1, 5, 6,
    6, 2, 1,

    // Top face
    1, 0, 4,
    4, 5, 1,

    // Bottom face
    2, 6, 7,
    7, 3, 2

        };


        private static string[] skyboxFilenames = new string[]
        {
         "textures/right.jpg",
         "textures/left.jpg",
         "textures/bottom.jpg",
         "textures/top.jpg",
         "textures/front.jpg",
         "textures/back.jpg"
        };

        #endregion Skybox

        #region Cube

        private static Vector3[] vertices_cube = new Vector3[]
        {
                // Front face
                new Vector3(-0.5f, -0.5f, 0.5f),
                new Vector3(0.5f, -0.5f, 0.5f),
                new Vector3(0.5f, 0.5f, 0.5f),
                new Vector3(-0.5f, 0.5f, 0.5f),

                // Back face
               new Vector3 (-0.5f, -0.5f, -0.5f),
               new Vector3 (0.5f, -0.5f, -0.5f),
               new Vector3 (0.5f, 0.5f, -0.5f),
               new Vector3 (-0.5f, 0.5f, -0.5f),

                // Left face
               new Vector3 (-0.5f, -0.5f, -0.5f),
               new Vector3 (-0.5f, -0.5f, 0.5f),
               new Vector3 (-0.5f, 0.5f, 0.5f),
               new Vector3 (-0.5f, 0.5f, -0.5f),

                // Right face
               new Vector3 (0.5f, -0.5f, -0.5f),
               new Vector3 (0.5f, -0.5f, 0.5f),
               new Vector3 (0.5f, 0.5f, 0.5f),
               new Vector3 (0.5f, 0.5f, -0.5f),

                 // Top face
               new Vector3 (-0.5f, 0.5f, 0.5f),
               new Vector3 (0.5f, 0.5f, 0.5f),
               new Vector3 (0.5f, 0.5f, -0.5f),
               new Vector3 (-0.5f, 0.5f, -0.5f),

                  // Bottom face
               new Vector3 (-0.5f, -0.5f, 0.5f),
               new Vector3 (0.5f, -0.5f, 0.5f),
               new Vector3 (0.5f, -0.5f, -0.5f),
               new Vector3 (-0.5f, -0.5f, -0.5f)
        };

        private static Vector2[] uvs_cube = new Vector2[]
        {
            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,1),

            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,1),
        };

        private static Vector3[] colors_cube = new Vector3[]
        {
               // Front face
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(1.0f, 1.0f, 1.0f),
               new Vector3(1.0f, 1.0f, 1.0f),

               // Back face
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(1.0f, 1.0f, 1.0f),
               new Vector3(1.0f, 1.0f, 1.0f),

               // Left face
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(1.0f, 1.0f, 1.0f),
               new Vector3(1.0f, 1.0f, 1.0f),

               // Right face
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(1.0f, 1.0f, 1.0f),
               new Vector3(1.0f, 1.0f, 1.0f),

               // Top face
               new Vector3(1.0f, 1.0f, 1.0f),
               new Vector3(1.0f, 1.0f, 1.0f),
               new Vector3(1.0f, 1.0f, 1.0f),
               new Vector3(1.0f, 1.0f, 1.0f),

               // Top face
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(0.0f, 0.0f, 0.0f),
               new Vector3(0.0f, 0.0f, 0.0f),
        };

        // Unsigned int array of indices
        private static uint[] indices_cube = new uint[] {
            	// Front face
            	0, 1, 2,
                2, 3, 0,

            	// Back face
            	4, 5, 6,
                6, 7, 4,

            	// Left face
            	8, 9, 10,
                10, 11, 8,

            	// Right face
            	12, 13, 14,
                14, 15, 12,

            	// Top face
            	16, 17, 18,
                18, 19, 16,

            	// Bottom face
            	20, 21, 22,
                22, 23, 20
};

        #endregion Cube

        #region Rectangle

        private static Vector3[] vertices_rectangle = new Vector3[]
        {
    new Vector3(-0.5f, 0.5f, -0.5f),   // Top-left
    new Vector3(0.5f, 0.5f, -0.5f),    // Top-right
    new Vector3(0.5f, -0.5f, -0.5f),   // Bottom-right
    new Vector3(-0.5f, -0.5f, -0.5f)   // Bottom-left
        };

        private static Vector3[] colors_rectangle = new Vector3[]
        {
    new Vector3(1f, 1f, 1f),    // Top-left (Red)
    new Vector3(1f, 1f, 1f),    // Top-right (Green)
    new Vector3(1f, 1f, 1f),    // Bottom-right (Blue)
    new Vector3(1f, 1f, 1f)     // Bottom-left (Yellow)
        };

        private static Vector2[] uvs_rectangle = new Vector2[]
        {
    new Vector2(0f, 1f),    // Top-left
    new Vector2(1f, 1f),    // Top-right
    new Vector2(1f, 0f),    // Bottom-right
    new Vector2(0f, 0f)     // Bottom-left
        };

        private static uint[] indices_rectangle = new uint[]
        {
    0, 1, 2,    // First triangle
    2, 3, 0     // Second triangle
        };

        #endregion Rectangle

        private static void Main()
        {
            game = new Game(userInterfaceHelper);

            Window.CreateWindow("OpenGL S1", Width, Height);
            Time.Init();

            //add a reshape callback to update the UI
            Window.OnReshapeCallbacks.Add(OnResize);

            //add a close callback to make sure we dispose of everythng properly
            Window.OnCloseCallbacks.Add(OnClose);

            //General OpenGL Settings
            SetupOpenGLSettings();

            //User Interface
            userInterfaceHelper.SetupUI(Width, Height, game);

            // Load shader files
            var cottageMaterial = ShaderProgram.Create("shaders\\cottageVert.vs", "shaders\\cottageFrag.fs");
            var gearMaterial = ShaderProgram.Create("shaders\\gearVert.vs", "shaders\\gearFrag.fs");
            var lightMaterial = ShaderProgram.Create("shaders/vertLight.vs", "shaders/fragLight.fs");
            var skyboxMaterial = ShaderProgram.Create("shaders/skyboxVert.vs", "shaders/skyboxFrag.fs");
            var skyboxMirrorMaterial = ShaderProgram.Create("shaders/skyboxMirrorVert.vs", "shaders/skyboxMirrorFrag.fs");

            //Load the textures
            List<OpenGL.Texture> cottageTextures = new List<OpenGL.Texture>();

            //Cottage
            var cottageTexture = new OpenGL.Texture("textures/Cottage_Clean_Base_Color.png");
            var alphaTexture = new OpenGL.Texture("textures/Cottage_Clean_Opacity.png");

            cottageTextures.Add(cottageTexture);
            cottageTextures.Add(alphaTexture);

            //Gear
            List<OpenGL.Texture> gearTextures = new List<OpenGL.Texture>();
            gearTextures.Add(new OpenGL.Texture("textures/Gear_1_BaseColor.png"));

            //Skybox
            List<OpenGL.Texture> skyBoxTextures = new List<OpenGL.Texture>();
            skyBoxTextures.Add(new OpenGL.Texture(skyboxFilenames));

            //Setting the values of the sampler2Ds to their respective texture unit
            //Texture unit 0 = baseColorMap (diffuseColor)
            //Texture unit 1 = alphaMap

            var baseColor = OpenGL.Gl.GetUniformLocation(cottageMaterial.ProgramID, "textureSampler");
            var alphaMap = OpenGL.Gl.GetUniformLocation(cottageMaterial.ProgramID, "alphaSampler");

            OpenGL.Gl.ProgramUniform1i(cottageMaterial.ProgramID, baseColor, 0);
            OpenGL.Gl.ProgramUniform1i(cottageMaterial.ProgramID, alphaMap, 1);

            //Do the same for gearMaterial
            //Texture unit 0 = baseColorMap (diffuseColor)
            baseColor = OpenGL.Gl.GetUniformLocation(gearMaterial.ProgramID, "textureSampler");

            OpenGL.Gl.ProgramUniform1i(gearMaterial.ProgramID, baseColor, 0);

            //Creating the vaos for the obj models

            //Gear
            LoadObjFile("models/Gear1.obj", out List<Vertex> vertices, out List<ObjLoader.Loader.Data.VertexData.Texture> uvs, out List<Normal> normals, out List<uint> indices);

            var geo_gear = CreateVAO(vertices.ToArray(), uvs.ToArray(), normals.ToArray(), indices.ToArray(), gearMaterial);

            //Cottage
            LoadObjFile("models/Cottage_FREE.obj", out List<Vertex> outputVertices, out List<ObjLoader.Loader.Data.VertexData.Texture> outputTextures, out List<Normal> outputNormals, out List<uint> outputIndices);

            var geo_cottage = CreateVAO(outputVertices.ToArray(), outputTextures.ToArray(), outputNormals.ToArray(), outputIndices.ToArray(), cottageMaterial);

            //Reflective sphere
            LoadObjFile("models/Sphere.obj", out List<Vertex> sphereVertices, out List<ObjLoader.Loader.Data.VertexData.Texture> sphereUVs, out List<Normal> sphereNormals, out List<uint> sphereIndices);

            var geo_sphere = CreateVAO(sphereVertices.ToArray(),sphereNormals.ToArray(), sphereIndices.ToArray(), skyboxMirrorMaterial);

            //Light cube
            var geo_light = CreateVAO(vertices_cube, indices_cube, lightMaterial);

            //Skybox
            var geo_skybox = new VAO(skyboxMaterial, new VBO<Vector3>(skyboxVertices), new VBO<uint>(skyboxIndices,BufferTarget.ElementArrayBuffer,BufferUsageHint.StaticRead));

            //Create skyBoxGameObject
            var obj_skyBox = new GameObject("Skybox", game, new MeshRenderer (skyboxMaterial, geo_skybox, skyBoxTextures));

            //Create cottage game object
            GameObject obj_cottage = new GameObject("Cottage", game, new MeshRenderer(cottageMaterial, geo_cottage, cottageTextures));

            //Create gear game object
            GameObject obj_gear = new GameObject("Gear", game, new MeshRenderer(gearMaterial, geo_gear, gearTextures));

            //Create skyboxMirrorObject
            GameObject obj_skyBoxMirror = new GameObject("SkyboxMirror", game, new MeshRenderer(skyboxMirrorMaterial, geo_sphere, skyBoxTextures));

            //Create light game object
            var obj_pointLight = new GameObject("Light source", game, new MeshRenderer(lightMaterial, geo_light));
            PointLight pointLight = new PointLight();
            MovementController lightController = new MovementController(true);
            obj_pointLight.AddComponent(lightController);
            obj_pointLight.AddComponent(pointLight);

            //Create camera game object
            GameObject obj_camera = new GameObject("Camera", game);
            MovementControllerManager movementControllerManager = new MovementControllerManager();
            Camera cameraComponent = new Camera();
            MovementController cameraController = new MovementController();
            obj_camera.AddComponent(movementControllerManager);
            obj_camera.AddComponent(cameraController);
            obj_camera.AddComponent(cameraComponent);

            //Make transformations
            obj_cottage.Transform.Position = new Vector3(0, 0, -10);
            obj_cottage.Transform.Scale = new Vector3(0.5f, 0.5f, 0.5f);

            obj_gear.Transform.Position = new Vector3(6, 0, -10);
            obj_gear.Transform.Scale = new Vector3(0.3f, 0.3f, 0.3f);

            obj_pointLight.Transform.Position = new Vector3(0, 0, 0);
            obj_pointLight.Transform.Scale = new Vector3(0.2f, 0.2f, 0.2f);
            obj_pointLight.Transform.Rotation = new Vector3(0.0f, 0.0f, 0.0f);

            obj_skyBoxMirror.Transform.Position = new Vector3(1, 1, 1);
            obj_skyBoxMirror.Transform.Scale = new Vector3(1, 1, 1);

            //Set main camera and add point light to the game
            game.MainCamera = cameraComponent;
            game.PointLights.Add(pointLight);

            // Add gameobjects to scene
            game.SceneGraph.Add(obj_cottage);
            game.SceneGraph.Add(obj_gear);
            game.SceneGraph.Add(obj_pointLight);
            game.SceneGraph.Add(obj_skyBox);
            game.SceneGraph.Add(obj_skyBoxMirror);
            game.SceneGraph.Add(obj_camera);

            //Hook input callbacks
            InputHelper.InitInputs();
            InputHelper.ButtonLPressedEvent += game.ToggleLightingCallback;

            //Window.SetScreenMode(new Compatibility.ScreenResolution(1919, 1080, 256, 60), true);
            var windowPosition = Window.GetWindowPosition();
            CursorRestriction.RestrictCursorToRectangle((int)windowPosition.X, (int)windowPosition.Y, (int)windowPosition.X + Width, (int)windowPosition.Y + Height);
            Window.ShowCursor(false);

            // Make sure to set up mouse event handlers for the window
            Window.OnMouseCallbacks.Add(OpenGL.UI.UserInterface.OnMouseClick);
            Window.OnMouseMoveCallbacks.Add(OpenGL.UI.UserInterface.OnMouseMove);

            // Game loop
            game.Start();

            while (Window.Open)
            {
                Window.HandleEvents();

                OnPreRenderFrame();

                game.Update();
                game.Render();

                OnPostRenderFrame();

                Time.Update();
            }
        }

        #region Other Callbacks

        private static void OnResize()
        {
            Width = Window.Width;
            Height = Window.Height;

            var windowPosition = Window.GetWindowPosition();

            OpenGL.UI.UserInterface.OnResize(Window.Width, Window.Height);
        }

        private static void OnClose()
        {
            // make sure to dispose of everything
            OpenGL.UI.UserInterface.Dispose();
            OpenGL.UI.BMFont.Dispose();
        }

        private static void OnPreRenderFrame()
        {
            // set up the OpenGL viewport and clear both the color and depth bits
            Gl.Viewport(0, 0, Window.Width, Window.Height);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

        private static void OnPostRenderFrame()
        {
            // Draw the user interface after everything else
            OpenGL.UI.UserInterface.Draw();

            // Swap the back buffer to the front so that the screen displays
            Window.SwapBuffers();
        }

        private static void OnMouseClick(int button, int state, int x, int y)
        {
            // take care of mapping the Glut buttons to the UI enums
            if (!OpenGL.UI.UserInterface.OnMouseClick(button + 1, (state == 0 ? 1 : 0), x, y))
            {
                // do other picking code here if necessary
            }
        }

        private static void OnMouseMove(int x, int y)
        {
            if (!OpenGL.UI.UserInterface.OnMouseMove(x, y))
            {
                // do other picking code here if necessary
            }
        }

        #endregion Other Callbacks

        #region ObjLoading

        private static void LoadObjFile(string path, out List<Vertex> outputVertices, out List<ObjLoader.Loader.Data.VertexData.Texture> outputTextures, out List<Normal> outputNormals, out List<uint> outputIndices)
        {
            //load obj file
            var objLoaderFactory = new ObjLoaderFactory();
            var objLoader = objLoaderFactory.Create();

            var fileStream = new FileStream(path, FileMode.Open);
            var result = objLoader.Load(fileStream);
            var groups = result.Groups;
            var faces = groups[0].Faces;

            //Cache the input arrays of the positions, uvs and normals
            var inputVertices = result.Vertices;
            var inputTextureCoordinates = result.Textures;
            var inputNormals = result.Normals;

            //Create the output lists
            outputVertices = new List<Vertex>(); //output positions
            outputIndices = new List<uint>(); //output indices
            outputTextures = new List<ObjLoader.Loader.Data.VertexData.Texture>(); //output Texture UVS
            outputNormals = new List<Normal>(); //output normals

            // Create a dictionary to store unique vertices based on their attributes
            Dictionary<Tuple<int, int, int>, int> vertexDictionary = new Dictionary<Tuple<int, int, int>, int>();

            //index mapping if a face consists of 4 vertices we need to map them in a way that creates 2 triangles
            Dictionary<int, int> indexMapping = new Dictionary<int, int>();
            indexMapping.Add(0, 0);
            indexMapping.Add(1, 1);
            indexMapping.Add(2, 2);
            indexMapping.Add(3, 0);
            indexMapping.Add(4, 2);
            indexMapping.Add(5, 3);

            //we have to bring the data from the obj file into a format that opengl can work with
            //that means we need a seperate array for positions, uvs, normals, indices etc.
            Console.WriteLine("Current obj loading progress in %: ");

            for (int i = 0; i < faces.Count; i++)
            {
                var progressInPercent = Math.Round(((float)i / (float)faces.Count) * 100);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(progressInPercent);
                var face = faces[i];

                if (face.Count == 3)
                {
                    for (int j = 0; j < face.Count; j++)
                    {
                        var vertexIndex = face[j].VertexIndex - 1; //subtract 1 because obj indeces are 1 based
                        var textureIndex = face[j].TextureIndex - 1;
                        var normalIndex = face[j].NormalIndex - 1;

                        var vertexAttributes = Tuple.Create(vertexIndex, textureIndex, normalIndex);

                        if (!vertexDictionary.TryGetValue(vertexAttributes, out int index))
                        {
                            // Vertex does not exist in the dictionary, add it to the output lists

                            var vertex = inputVertices[vertexIndex];
                            var textureUV = inputTextureCoordinates[textureIndex];
                            var normal = inputNormals[normalIndex];

                            outputVertices.Add(vertex);
                            outputTextures.Add(textureUV);
                            outputNormals.Add(normal);

                            // Add the new vertex to the dictionary with its index
                            index = outputVertices.Count - 1;
                            vertexDictionary.Add(vertexAttributes, index);
                        }

                        // Use the index of the vertex (either existing or newly added) for the triangle
                        outputIndices.Add((uint)index);
                    }
                }
                else if (face.Count == 4)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        var faceVertexIndex = indexMapping[j];

                        var vertexIndex = face[faceVertexIndex].VertexIndex - 1; //subtract 1 because obj indeces are 1 based
                        var textureIndex = face[faceVertexIndex].TextureIndex - 1;
                        var normalIndex = face[faceVertexIndex].NormalIndex - 1;

                        var vertexAttributes = Tuple.Create(vertexIndex, textureIndex, normalIndex);

                        if (!vertexDictionary.TryGetValue(vertexAttributes, out int index))
                        {
                            // Vertex does not exist in the dictionary, add it to the output lists

                            var vertex = inputVertices[vertexIndex];
                            var textureUV = inputTextureCoordinates[textureIndex];
                            var normal = inputNormals[normalIndex];

                            outputVertices.Add(vertex);
                            outputTextures.Add(textureUV);
                            outputNormals.Add(normal);

                            // Add the new vertex to the dictionary with its index
                            index = outputVertices.Count - 1;
                            vertexDictionary.Add(vertexAttributes, index);
                        }

                        // Use the index of the vertex (either existing or newly added) for the triangle
                        outputIndices.Add((uint)index);
                    }
                }

                else if (face.Count == 5)
                {
                    Console.WriteLine("The obj file: " + path +  " contains five sided faces. This algorithm currently only supports 3 and 4 sided faces.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Successfully loaded obj-Model from: " + path);
        }

        #endregion ObjLoading

        #region OpenGL Helper Methods

        private static VAO CreateVAO(Vector3[] vertices, Vector2[] uvs, Vector3[] normals, uint[] indices, ShaderProgram material)
        {
            List<IGenericVBO> vbos_model = new List<IGenericVBO>();
            vbos_model.Add(new GenericVBO<Vector3>(new VBO<Vector3>(vertices), "in_position"));
            vbos_model.Add(new GenericVBO<Vector3>(new VBO<Vector3>(normals), "in_normal"));
            vbos_model.Add(new GenericVBO<Vector2>(new VBO<Vector2>(uvs), "in_texcoords"));

            vbos_model.Add(new GenericVBO<uint>(new VBO<uint>(indices, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead)));

            var vbo_model = vbos_model.ToArray();

            return new VAO(material, vbo_model);
        }
        private static VAO CreateVAO(Vector3[] vertices, uint[] indices, ShaderProgram material)
        {
            List<IGenericVBO> vbos_model = new List<IGenericVBO>();
            vbos_model.Add(new GenericVBO<Vector3>(new VBO<Vector3>(vertices), "in_position"));

            vbos_model.Add(new GenericVBO<uint>(new VBO<uint>(indices, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead)));

            var vbo_model = vbos_model.ToArray();

            return new VAO(material, vbo_model);
        }

        private static VAO CreateVAO(Vertex[] vertices, ObjLoader.Loader.Data.VertexData.Texture[] uvs, Normal[] normals, uint[] indices, ShaderProgram material)
        {
            List<IGenericVBO> vbos_model = new List<IGenericVBO>();
            vbos_model.Add(new GenericVBO<Vertex>(new VBO<Vertex>(vertices), "in_position"));
            vbos_model.Add(new GenericVBO<Normal>(new VBO<Normal>(normals), "in_normal"));
            vbos_model.Add(new GenericVBO<ObjLoader.Loader.Data.VertexData.Texture>(new VBO<ObjLoader.Loader.Data.VertexData.Texture>(uvs), "in_texcoords"));

            vbos_model.Add(new GenericVBO<uint>(new VBO<uint>(indices, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead)));

            var vbo_model = vbos_model.ToArray();

            return new VAO(material, vbo_model);
        }
        private static VAO CreateVAO(Vertex[] vertices,  Normal[] normals, uint[] indices, ShaderProgram material)
        {
            List<IGenericVBO> vbos_model = new List<IGenericVBO>();
            vbos_model.Add(new GenericVBO<Vertex>(new VBO<Vertex>(vertices), "in_position"));
            vbos_model.Add(new GenericVBO<Normal>(new VBO<Normal>(normals), "in_normal"));

            vbos_model.Add(new GenericVBO<uint>(new VBO<uint>(indices, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead)));

            var vbo_model = vbos_model.ToArray();

            return new VAO(material, vbo_model);
        }
        private static VAO CreateVAO(Vertex[] vertices, uint[] indices, ShaderProgram material)
        {
            List<IGenericVBO> vbos_model = new List<IGenericVBO>();
            vbos_model.Add(new GenericVBO<Vertex>(new VBO<Vertex>(vertices), "in_position"));

            vbos_model.Add(new GenericVBO<uint>(new VBO<uint>(indices, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead)));

            var vbo_model = vbos_model.ToArray();

            return new VAO(material, vbo_model);
        }

        private static void SetupOpenGLSettings()
        {
            //Enable depth testing to ensure correct z-ordering of our fragments
            Gl.DepthFunc(DepthFunction.Lequal);
            Gl.Enable(EnableCap.DepthTest);
            Gl.Enable(EnableCap.Blend);
            Gl.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            Gl.PolygonMode(MaterialFace.Front, PolygonMode.Fill);

            // Scale up (magnify)
            Gl.TexParameteri(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter,
            TextureParameter.Nearest);
            // Scale down (minify)
            Gl.TexParameteri(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter,
            TextureParameter.Nearest);
        }

        #endregion OpenGL-HelperMethods
    }
}