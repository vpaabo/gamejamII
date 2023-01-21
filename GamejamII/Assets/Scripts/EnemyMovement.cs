using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameObject movementTarget;
    private NavMeshAgent agent;

    private void Awake()
    {
        movementTarget = GameObject.Find("PlayerArmature");
        
    }
    private void Start()
    {
        agent = GetComponentInChildren<NavMeshAgent>();
        agent.SetDestination(movementTarget.transform.position);
        
        LeanTween.scaleY(gameObject, 0.9f, .5f).setLoopPingPong(-1);
    }

    // Update is called once per frame
    void Update()
    {
        //print(movementTarget.transform.position);
        agent.SetDestination(movementTarget.transform.position);
        /*
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    // Executes below code if AI has stopped moving//
                    agent.SetDestination(movementTarget.transform.position);
                    print("moving to " + agent.destination.ToString());
                }
            }
        }*/
                
    }

    
}
