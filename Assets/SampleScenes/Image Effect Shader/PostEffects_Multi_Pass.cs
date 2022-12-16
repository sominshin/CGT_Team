using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostEffects_Multi_Pass : MonoBehaviour
{
    Shader myShader;   
    Material myMaterial;

    void Start()
    {
        myShader = Shader.Find("My/PostEffects_Multi_Pass");   
        myMaterial = new Material(myShader);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 1);  
    }
}

