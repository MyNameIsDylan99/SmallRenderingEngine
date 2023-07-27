#version 400 core
layout (location = 0) in vec3 in_position;

uniform vec3 lightColor;

out vec3 color;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;


void main()
{
// note that we read the multiplication from right to left
gl_Position = projection * view * model * vec4(in_position, 1.0);

color = lightColor;
}