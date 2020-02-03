// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:0,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:32491,y:32699,varname:node_2865,prsc:2|emission-1574-OUT,custl-4005-OUT;n:type:ShaderForge.SFN_Multiply,id:4005,x:32082,y:32976,varname:node_4005,prsc:2|A-1617-OUT,B-3937-RGB,C-5725-A,D-3671-OUT;n:type:ShaderForge.SFN_Append,id:8779,x:31165,y:32679,varname:node_8779,prsc:2|A-1552-OUT,B-3104-OUT;n:type:ShaderForge.SFN_Multiply,id:2803,x:31375,y:32589,varname:node_2803,prsc:2|A-9988-T,B-8779-OUT;n:type:ShaderForge.SFN_Time,id:9988,x:31165,y:32451,varname:node_9988,prsc:2;n:type:ShaderForge.SFN_Add,id:1912,x:31570,y:32422,varname:node_1912,prsc:2|A-5505-UVOUT,B-2803-OUT;n:type:ShaderForge.SFN_TexCoord,id:5505,x:31375,y:32352,varname:node_5505,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:8909,x:31766,y:32361,ptovrint:False,ptlb:TEX,ptin:_TEX,varname:node_8909,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1912-OUT;n:type:ShaderForge.SFN_Power,id:64,x:31983,y:32297,varname:node_64,prsc:2|VAL-8909-RGB,EXP-1758-OUT;n:type:ShaderForge.SFN_Slider,id:1758,x:31662,y:32176,ptovrint:False,ptlb:node_1758,ptin:_node_1758,varname:node_1758,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Append,id:3361,x:31146,y:33620,varname:node_3361,prsc:2|A-5836-OUT,B-401-OUT;n:type:ShaderForge.SFN_Time,id:3631,x:31146,y:33389,varname:node_3631,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:598,x:31356,y:33293,varname:node_598,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:5948,x:31553,y:33362,varname:node_5948,prsc:2|A-598-UVOUT,B-8840-OUT;n:type:ShaderForge.SFN_Multiply,id:8840,x:31332,y:33535,varname:node_8840,prsc:2|A-3631-T,B-3361-OUT;n:type:ShaderForge.SFN_Multiply,id:1617,x:31906,y:32640,varname:node_1617,prsc:2|A-64-OUT,B-4062-RGB,C-4062-A,D-314-RGB,E-5725-A;n:type:ShaderForge.SFN_Color,id:4062,x:31691,y:32640,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_4062,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_VertexColor,id:5725,x:31691,y:32850,varname:node_5725,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:314,x:31716,y:33098,ptovrint:False,ptlb:node_314,ptin:_node_314,varname:node_314,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-5948-OUT;n:type:ShaderForge.SFN_Multiply,id:1574,x:32150,y:32734,varname:node_1574,prsc:2|A-1617-OUT,B-5725-RGB;n:type:ShaderForge.SFN_Color,id:3937,x:32038,y:33198,ptovrint:False,ptlb:node_3937,ptin:_node_3937,varname:node_3937,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Slider,id:3671,x:31716,y:33389,ptovrint:False,ptlb:node_3671,ptin:_node_3671,varname:node_3671,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Slider,id:1552,x:30734,y:32703,ptovrint:False,ptlb:node_1552,ptin:_node_1552,varname:node_1552,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-10,cur:0,max:10;n:type:ShaderForge.SFN_Slider,id:3104,x:30753,y:32819,ptovrint:False,ptlb:node_1552_copy,ptin:_node_1552_copy,varname:_node_1552_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-10,cur:0,max:10;n:type:ShaderForge.SFN_Slider,id:5836,x:30712,y:33496,ptovrint:False,ptlb:node_1552_copy_copy,ptin:_node_1552_copy_copy,varname:_node_1552_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-10,cur:0,max:10;n:type:ShaderForge.SFN_Slider,id:401,x:30752,y:33688,ptovrint:False,ptlb:node_1552_copy_copy_copy,ptin:_node_1552_copy_copy_copy,varname:_node_1552_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-10,cur:0,max:10;proporder:8909-1758-4062-314-3937-3671-5836-401-3104-1552;pass:END;sub:END;*/

Shader "" {
    Properties {
        _TEX ("TEX", 2D) = "white" {}
        _node_1758 ("node_1758", Range(0, 10)) = 1
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _node_314 ("node_314", 2D) = "white" {}
        _node_3937 ("node_3937", Color) = (0.5,0.5,0.5,1)
        _node_3671 ("node_3671", Range(0, 10)) = 0
        _node_1552_copy_copy ("node_1552_copy_copy", Range(-10, 10)) = 0
        _node_1552_copy_copy_copy ("node_1552_copy_copy_copy", Range(-10, 10)) = 0
        _node_1552_copy ("node_1552_copy", Range(-10, 10)) = 0
        _node_1552 ("node_1552", Range(-10, 10)) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _TEX; uniform float4 _TEX_ST;
            uniform sampler2D _node_314; uniform float4 _node_314_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1758)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float4, _node_3937)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_3671)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552_copy)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552_copy_copy)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552_copy_copy_copy)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_9988 = _Time;
                float _node_1552_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552 );
                float _node_1552_copy_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552_copy );
                float2 node_1912 = (i.uv0+(node_9988.g*float2(_node_1552_var,_node_1552_copy_var)));
                float4 _TEX_var = tex2D(_TEX,TRANSFORM_TEX(node_1912, _TEX));
                float _node_1758_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1758 );
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float4 node_3631 = _Time;
                float _node_1552_copy_copy_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552_copy_copy );
                float _node_1552_copy_copy_copy_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552_copy_copy_copy );
                float2 node_5948 = (i.uv0+(node_3631.g*float2(_node_1552_copy_copy_var,_node_1552_copy_copy_copy_var)));
                float4 _node_314_var = tex2D(_node_314,TRANSFORM_TEX(node_5948, _node_314));
                float3 node_1617 = (pow(_TEX_var.rgb,_node_1758_var)*_Color_var.rgb*_Color_var.a*_node_314_var.rgb*i.vertexColor.a);
                float3 emissive = (node_1617*i.vertexColor.rgb);
                float4 _node_3937_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_3937 );
                float _node_3671_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_3671 );
                float3 finalColor = emissive + (node_1617*_node_3937_var.rgb*i.vertexColor.a*_node_3671_var);
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define _GLOSSYENV 1
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _TEX; uniform float4 _TEX_ST;
            uniform sampler2D _node_314; uniform float4 _node_314_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1758)
                UNITY_DEFINE_INSTANCED_PROP( float4, _Color)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552_copy)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552_copy_copy)
                UNITY_DEFINE_INSTANCED_PROP( float, _node_1552_copy_copy_copy)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                UNITY_SETUP_INSTANCE_ID( i );
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 node_9988 = _Time;
                float _node_1552_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552 );
                float _node_1552_copy_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552_copy );
                float2 node_1912 = (i.uv0+(node_9988.g*float2(_node_1552_var,_node_1552_copy_var)));
                float4 _TEX_var = tex2D(_TEX,TRANSFORM_TEX(node_1912, _TEX));
                float _node_1758_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1758 );
                float4 _Color_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Color );
                float4 node_3631 = _Time;
                float _node_1552_copy_copy_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552_copy_copy );
                float _node_1552_copy_copy_copy_var = UNITY_ACCESS_INSTANCED_PROP( Props, _node_1552_copy_copy_copy );
                float2 node_5948 = (i.uv0+(node_3631.g*float2(_node_1552_copy_copy_var,_node_1552_copy_copy_copy_var)));
                float4 _node_314_var = tex2D(_node_314,TRANSFORM_TEX(node_5948, _node_314));
                float3 node_1617 = (pow(_TEX_var.rgb,_node_1758_var)*_Color_var.rgb*_Color_var.a*_node_314_var.rgb*i.vertexColor.a);
                o.Emission = (node_1617*i.vertexColor.rgb);
                
                float3 diffColor = float3(0,0,0);
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
