using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeScript : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            anim.SetBool("dodge", true);
        }
        else
        {
            anim.SetBool("dodge", false);
        }
    }
}
