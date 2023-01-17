using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    //public bool attacking;
    public Animator controller;

    private void Start()
    {
        print("start");
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Yes");
            controller.SetBool("attack", true);
        }
        else
        {
            Debug.Log("No");
            controller.SetBool("attack", false);
        }
        //controller.SetBool("attack", true);
    
    }
}
