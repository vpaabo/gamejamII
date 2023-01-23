using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    [SerializeField] private Camera cameraref;
    [SerializeField] private Color[] colors;
    [SerializeField] private float colorCgangeSpeed;
    [SerializeField] private float time;

    private float currenTime;
    private int colorIndex;

    private void Awake()
    {
        cameraref = Camera.main;
    }

     void Start()
    {
        
    }

     void Update()
    {
        ColorChange(); 
        ColorChangeTime();
    }

    private void ColorChange()
    {
        cameraref.backgroundColor = Color.Lerp(cameraref.backgroundColor, colors[colorIndex], colorCgangeSpeed * Time.deltaTime);
    }

    private void ColorChangeTime()
    {
        if (currenTime <= 0)
        {
            colorIndex++;
            CheckColorIndex();
            currenTime = time;
        }
        else
        {
            currenTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndex()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void OnDestroy()
    {
        cameraref.backgroundColor = colors[0];
    }




}
