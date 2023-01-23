using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision col)
    {
        //print(collisionInfo.gameObject.tag);
        if (col.gameObject.tag.Equals("Obsicle"))
        {
            movement.enabled = false;
            //print("collision");
            FindObjectOfType<GameManager>().EndGame();
        }
        
            
        }

    }

