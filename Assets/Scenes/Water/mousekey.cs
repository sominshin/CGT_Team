using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousekey : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("���콺 ���� ��ư Ŭ��");
            anim.speed = 1.0f;
        }

        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("���콺 ������ ��ư Ŭ��");
            anim.speed = 0.0f;
        }
    }

}
