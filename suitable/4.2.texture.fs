#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;

// mix variable
uniform float mixValue;

void main()
{
    // Flip the X coordinate for texture2
    vec2 flippedTexCoord = vec2(1.0 - TexCoord.x, TexCoord.y);
    
    // linearly interpolate between both textures (80% container, 20% awesomeface)
    // Use the flipped coordinates for texture2
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, flippedTexCoord), mixValue);
}