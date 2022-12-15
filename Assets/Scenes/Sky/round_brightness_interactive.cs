using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class round_brightness_interactive : MonoBehaviour
{
    int brightness = 1;
    Renderer MyRenderer;

    void Start()
    {
        MyRenderer = gameObject.GetComponent<Renderer>();
        MyRenderer.material.SetInt("_Brightness", brightness);

    }
    private void OnMouseDown()
    {
        brightness = -1 * brightness;
        MyRenderer.material.SetInt("_Brightness", brightness);

    }
}
