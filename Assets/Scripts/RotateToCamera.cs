using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{
    /*public GameObject camera;
    private Transform targetTransform;

    private float speed = 1f;

    private void Start()
    {
        targetTransform = camera.transform;
    }*/
    void Update()
    {
        transform.LookAt(Camera.main.transform.position, -Vector3.up);
        // then lock rotation to Y axis only...
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
    }
}
