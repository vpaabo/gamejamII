using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TreeResizer : MonoBehaviour
{
    private GameObject player;

    private float newSize;

    
    public Transform center;
    public float ScaleMultiplier;
    private Vector3 initialScale = Vector3.one;
    private void Start()
    {
        player = GameObject.Find("PlayerArmature");
        
    }
    void Update()
    {
        
        
        float distance = Vector3.Distance(player.transform.position, transform.position);
        transform.localScale = initialScale * distance * ScaleMultiplier;
    }
}
