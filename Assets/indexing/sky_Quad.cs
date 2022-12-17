using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky_Quad : MonoBehaviour
{
    public Vector3[] newVertices;
    public int[] newTriangles;

    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;

    }

  
}
