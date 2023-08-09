#version 400 core
layout (location = 0) in vec3 in_position;
layout (location = 1) in vec3 in_normal;
layout (location = 2) in vec2 in_texcoords;
layout (location = 3) in vec3 in_tangent;
layout (location = 4) in vec3 in_bitangent;
layout (location = 5) in vec3 in_color;

out VS_OUT {
    vec3 position;
    vec2 uv;
    mat3 TBN;
} vs_out;

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

vs_out.uv = in_texcoords;
vs_out.position = (model * vec4(in_position,1.0)).xyz;

vec3 T = normalize(vec3(model * vec4(in_tangent, 0.0)));
vec3 B = normalize(vec3(model * vec4(in_bitangent, 0.0)));
vec3 N = normalize(vec3(model * vec4(in_normal, 0.0)));

vs_out.TBN = mat3(T,B,N);

}