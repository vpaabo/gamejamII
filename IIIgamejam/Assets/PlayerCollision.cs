using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        print(collisionInfo.gameObject.tag);
        if (collisionInfo.gameObject.tag == "Obsicle")
        {
            movement.enabled= false;

        }

    }
}
