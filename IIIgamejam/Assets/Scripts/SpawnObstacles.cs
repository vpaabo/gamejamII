using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public int Amount;

    public GameObject obstacle;

    void Start()
    {
        for (int i = 0; i < Amount; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-7, 7), 1, Random.Range(10, 1000));
            GameObject obs = GameObject.Instantiate(obstacle, pos, Quaternion.identity);
            obs.transform.localScale = new Vector3(Random.Range(0.5f, 2), 1, 1);
        }
    }

    
    void Update()
    {
        
    }
}
