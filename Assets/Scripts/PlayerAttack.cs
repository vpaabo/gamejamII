using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    //public bool attacking;
    public Animator controller;

    public List<GameObject> enemies;

    private bool atck;

    public int Score;

    public bool IsInitialized { get; private set; }
    private void Awake()
    {
        Score = 0;
        enemies = new List<GameObject>();
        atck = false;
    }
    private void Start()
    {
        //print("start");
        IsInitialized = true;

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //Debug.Log("Yes");
            controller.SetBool("attack", true);
            atck = true;
        }
        else
        {
            //Debug.Log("No");
            controller.SetBool("attack", false);
            atck = false;
        }
        //controller.SetBool("attack", true);

        DetectHit();
        Score += 10;

        
        
    }

    public void AddEnemyToList(GameObject e)
    {
        enemies.Add(e);
    }
    public void DetectHit()
    {
        
        foreach(GameObject e in enemies)
        {
            if( (e.transform.position - transform.position).sqrMagnitude < 4)
            {
                if (atck)
                {
                    GameObject.Destroy(e);
                    ChangeScore(100);
                }
                else
                { 
                    ChangeScore(-100);
                }
                print(Score);   
                break;
            }
        }
    }

    public void ChangeScore(int amount)
    {
        ScoreScript.scoreValue += 10;
        //Score += amount;
    }
}
