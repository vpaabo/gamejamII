using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
    
{
    public static int scoreValue = 0;
    public TextMeshProUGUI score;
   
    void Start()
    {
        //score = GetComponent<TM>(); 
    }

  
    void Update()
    {
        //print("koll");
        score.text = "Score: " + scoreValue; 
    }
}
