using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene_water : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Water");
    }
}
