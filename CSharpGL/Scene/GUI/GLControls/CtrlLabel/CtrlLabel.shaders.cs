﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// A rectangle control that displays an image.
    /// </summary>
    public partial class CtrlLabel
    {
        private const string inPosition = "inPosition";
        private const string inUV = "inUV";
        private const string inTextureIndex = "inTextureIndex";

        private const string vert =
            @"#version 330 core

in vec2 " + inPosition + @";
in vec2 " + inUV + @";
in float " + inTextureIndex + @";

out vec2 passUV;
out float passTextureIndex;

void main(void) {
	gl_Position = vec4(inPosition, 0.0, 1.0);
    passUV = inUV;
    passTextureIndex = inTextureIndex;
}
";
        private const string frag =
            @"#version 330 core

in vec2 passUV;
in float passTextureIndex;

uniform sampler2DArray glyphTexture;

out vec4 out_Color;

void main(void) {
    out_Color = texture(glyphTexture, vec3(passUV, floor(passTextureIndex)));
}
";
    }
}
