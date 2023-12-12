# OpenGL - Game Engine

## Introduction

In the last module of my diploma at SAE Institute Zürich, we looked at Graphics Programming and how game engines are structured behind the scenes.
For my assignment I worked on a game engine (it is more of a rendering engine right now) that is built upon giawas opengl4csharp framework: https://github.com/giawa/opengl4csharp

## Functionality

The game engine currently includes following features:

- Efficient loading of 3D-Models that are in the Wavefront OBJ - Format.
- Switching between different scenes
- Input Handling
- Moveable camera
- UI
- Directional lights
- Point lights
- Lit shaders using Blinn-Phong-Modell
- Support for Normalmaps
- Automatic calculation of tangent and bitangent when loading 3D-Models.
- Skybox and skybox mirror

## Self-reflection

For my studies I also wrote a document where I explain in detail what my learnings, struggles and thoughts on the future of this project are.
You can find it inside the Documents folder under the root directory.

## Controls

### Movement
#### WASD
Moves the currently active MovementController along the local x and z axis.
#### EQ
Moves the currently active MovementController along the local y axis use E for up and Q for down.
#### Mouse Movement
Rotates the currently active MovementController.
#### Spacebar
Changes the currently active MovementController.

### Pause Menu
#### Escape
Toggles the pause menu on and off and lets you use your cursor again.

### Other
#### L
Toggles lighting calculations on and off.
