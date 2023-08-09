#version 400 core
layout (location = 0) in vec3 in_position;

out vec3 TexCoords;

uniform mat4 projection;
uniform mat4 view;

void main()
{
    mat4 viewWOTranslation = mat4(mat3(view));

    TexCoords = vec3(in_position.x, -in_position.y, -in_position.z);
    vec4 pos = projection * viewWOTranslation * vec4(in_position, 1.0);
    gl_Position = pos.xyww;
}

