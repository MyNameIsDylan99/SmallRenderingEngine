#version 400 core
layout (location = 0) in vec3 in_position;
layout (location = 1) in vec3 in_normal;
layout (location = 2) in vec2 in_texcoords;
layout (location = 3) in vec2 in_color;


out vec3 normal;
out vec2 uv;
out vec3 position;

uniform float time;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform mat4 tangentToWorld;


void main()
{
// note that we read the multiplication from right to left
gl_Position = projection * view * model * vec4(in_position, 1.0);

normal = normalize(mat3(tangentToWorld) * in_normal);
uv = in_texcoords;
position = (model * vec4(in_position,1.0)).xyz;

}