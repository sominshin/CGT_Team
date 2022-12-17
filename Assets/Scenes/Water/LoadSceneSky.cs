using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneSky : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Sky");
    }
}
