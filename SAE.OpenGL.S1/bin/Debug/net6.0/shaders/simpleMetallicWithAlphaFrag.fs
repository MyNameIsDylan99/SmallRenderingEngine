#version 400 core

uniform vec3 color;

//Lighting parameters
uniform bool enableLighting;
uniform mat4 lightData;
uniform bool useBlinn;

//directional Light
uniform bool useDirectional;
uniform vec3 directionalColor;
uniform vec3 directionalLight;

uniform sampler2D textureSampler;
uniform sampler2D alphaSampler;
uniform sampler2D normalSampler;
uniform sampler2D roughnessSampler;
uniform sampler2D metallicSampler;

in VS_OUT
{
   vec3 position;
   vec2 uv;
   mat3 TBN;
} fs_in;

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
   float hardness = lightData[3].w;

   //texture sampling
   vec3 baseColor = texture2D(textureSampler, fs_in.uv).rgb * color;
   float alpha = 1.0 - texture2D(alphaSampler,fs_in.uv).r;
   vec3 normal = texture2D(normalSampler,fs_in.uv).rgb;
   normal = normal * 2.0 - 1.0;
   normal = normalize(fs_in.TBN * normal);
   float diffuseIntensity = texture2D(roughnessSampler, fs_in.uv).r;
   float specularIntensity = texture2D(metallicSampler, fs_in.uv).r;

   //Lighting
   vec3 lightDirection = normalize(lightPosition - fs_in.position);
   vec3 viewDirection = normalize(viewPosition - fs_in.position);

   float distanceToLight = length(lightPosition-fs_in.position);
   float k = 1/pow(distanceToLight,2);

   //directional
   float directionalIntensity = max(dot(directionalLight, normal),0);
   vec3 directional = directionalIntensity * directionalColor;

   vec3 reflectionDirection;

   // Reflect needs the light direction from the light position to vertex position:
   // L - 2.0 * dot(N, L) * N.
   if(!useBlinn)
   reflectionDirection = reflect(-lightDirection, normal);
   else
   reflectionDirection = normalize(viewDirection + lightDirection);
   

   vec3 ambient = ambientReflection(ambientIntensity, 1.0f, ambientLightColor);
   vec3 diffuse = diffuseReflection(diffuseIntensity,1.0f,pointLightColor,lightDirection,normal);
   vec3 specular = specularReflection(specularIntensity, 1.0f,pointLightColor, hardness, viewDirection, reflectionDirection);

   vec3 finalColor = baseColor * color;

   if(enableLighting)
   {
      if(!useDirectional)
   finalColor *= (ambient + k*(diffuse + specular));
   else
   finalColor *= (ambient + k*(diffuse + specular) + directional);
   }

   fragColor = vec4(finalColor, alpha);
}