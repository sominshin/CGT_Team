using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacekey : MonoBehaviour

{
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))

        {

            Debug.Log("스페이스 키 누름");
            Anim.speed = 1.0f;

        }


        if (Input.GetKeyUp(KeyCode.Space))

        {

            Debug.Log("스페이스 키 손뗌");
            Anim.speed = 0.0f;

        }


    }
}

