using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CausticProjector : MonoBehaviour
{
    public Projector pr;
    public int framePerSecond = 30;
    public Texture[] causticsTex;
    void Start()
    {
        pr = GetComponent<Projector>();
    }

    // Update is called once per frame
    void Update()
    {
        int cuasticIndex = (int)(Time.time * framePerSecond) % causticsTex.Length;
        pr.material.SetTexture("_MainTex", causticsTex[cuasticIndex]);
    }
}
