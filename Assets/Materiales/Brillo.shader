// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/Brillo"
{
    Properties
    {
        _OutlineColor("Outline Color", Color) = (1, 1, 1, 1)
        _OutlineWidth("Outline Width", Range(0, 0.1)) = 0.02
        _OutlineBlinkSpeed("Outline Blink Speed", Range(0, 5)) = 1.0
    }
    SubShader
    {
Tags { "RenderType"="Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 pos : POSITION;
            };

            float4 _OutlineColor;
            float _OutlineWidth;
            float _OutlineBlinkSpeed;
            
            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                return o;
            }

            half4 frag (v2f i) : SV_Target
            {
                // Calculate the outline width based on time
                float outlineWidth = _OutlineWidth + sin(_Time.y * _OutlineBlinkSpeed) * 0.02;

                // Calculate the outline color
                half4 outlineColor = _OutlineColor;

                // Calculate the distance to the outline
                float distanceToOutline = fwidth(i.pos.x) + fwidth(i.pos.y);

                // Apply the outline effect
                half4 finalColor = outlineColor * smoothstep(outlineWidth, outlineWidth + 0.01, distanceToOutline);

                return finalColor;
            }
            ENDCG
        }

    }
}
