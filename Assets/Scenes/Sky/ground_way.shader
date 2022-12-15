Shader "Custom/ground_way"
{
    Properties
    {
        _Color("Color", Color) = (1,1,1,1)
        _MainTex1("Albedo (RGB)", 2D) = "white" {}
        _MainTex2("Albedo (RGB)", 2D) = "white" {}
        _GG("GG", Range(0, 2)) = 1
        _Speed("Speed", Range(0, 20)) = 1


    }
        SubShader
        {
            Tags { "RenderType" = "Opaque" }

            CGPROGRAM
            #pragma surface surf Standard fullforwardshadows

            sampler2D _MainTex1;
            sampler2D _MainTex2;
            float _GG;
            float _Speed;
            fixed4 _Color;

            struct Input
            {
                float2 uv_MainTex1;
                float2 uv_MainTex2;
            };

            void surf(Input IN, inout SurfaceOutputStandard o)
            {

                fixed4 d = tex2D(_MainTex2, float2(IN.uv_MainTex2.x, IN.uv_MainTex2.y - _Time.y * _Speed));
                fixed4 c = tex2D(_MainTex1, IN.uv_MainTex1 + d.r * _GG);

                o.Emission = c.rgb * d.rgb;
                o.Alpha = c.a * d.a;

            }
            ENDCG
        }
            FallBack "Diffuse"
}
