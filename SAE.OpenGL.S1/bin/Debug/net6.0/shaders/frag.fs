#version 400 core

uniform vec3 color;

//Lighting parameters
uniform bool enableLighting;
uniform mat4 lightData;

//directional Light
uniform vec3 directionalLight;

uniform sampler2D textureSampler;
uniform sampler2D alphaSampler;


in vec3 position;
in vec3 normal;
in vec2 uv;

out vec4 fragColor;

vec3 ambientReflection(float intensity, float factor, vec3 lightColor)
{
   //I = ambientIntensity * ambientReflectionCoefficient
   float i = intensity * factor;

return lightColor * i;
}

vec3 diffuseReflection(float intensity, float factor, vec3 lightColor, vec3 lightDirection, vec3 normal)
{
   //I = dot(lightDirection, normal) * intensity * diffuseReflectionCoefficient;
   float i = dot(lightDirection,normal) * intensity * factor;

   return lightColor * i;
}

vec3 specularReflection(float intensity, float factor, vec3 lightColor, float hardness, vec3 viewDirection, vec3 reflectionDirection)
{
   //I = pow(dot(viewDirection, reflectionDirection),n) * intensity * specularReflectionCoefficient;
   //n = hardness / specular reflection exponent

   float dotViewReflection = max(dot(viewDirection, reflectionDirection), 0);
   float i = pow(dotViewReflection, hardness) * intensity * factor;

   return lightColor * i;
}

void main()
{

   vec3 lightPosition = lightData[0].xyz;
   vec3 ambientLightColor = lightData[1].xyz;
   vec3 pointLightColor = lightData[2].xyz;
   vec3 viewPosition = lightData[3].xyz;

   float ambientIntensity = lightData[0].w;
   float diffuseIntensity = lightData[1].w;
   float specularIntensity = lightData[2].w;
   float hardness = lightData[3].w;

   vec3 baseColor = texture2D(textureSampler, uv).rgb * color;
   float alpha = 1.0 - texture2D(alphaSampler,uv).r;

   //Lighting
   vec3 lightDirection = normalize(lightPosition - position);
   vec3 viewDirection = normalize(viewPosition - position);

   // Reflect needs the light direction from the light position to vertex position:
   // L - 2.0 * dot(N, L) * N.
   vec3 reflectionDirection = reflect(-lightDirection, normal);

   vec3 ambient = ambientReflection(ambientIntensity, 1.0f, ambientLightColor);
   vec3 diffuse = diffuseReflection(diffuseIntensity,1.0f,pointLightColor,lightDirection,normal);
   vec3 specular = specularReflection(specularIntensity, 1.0f,pointLightColor, 64.0f, viewDirection, reflectionDirection);

   vec3 finalColor = baseColor * color;

   if(enableLighting)
   finalColor *= (ambient + diffuse + specular);

   fragColor = vec4(finalColor, alpha);
}