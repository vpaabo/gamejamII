using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //public bool attacking;
    public Animator controller;

    private void Start()
    {
        //attacking = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            controller.SetBool("attack", true);
        }
        else
        {
            controller.SetBool("attack", false);
        }
    }
}
