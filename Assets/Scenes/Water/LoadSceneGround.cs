using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneGround : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Ground");
    }
}
