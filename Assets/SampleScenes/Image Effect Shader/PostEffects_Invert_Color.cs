using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PostEffects_Invert_Color : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial;

    void Start()
    {
        myShader = Shader.Find("My/PostEffects_Invert_Color");    // image effect shader file must have been created
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
        Graphics.Blit(source, destination, myMaterial, 0);
    }
}
