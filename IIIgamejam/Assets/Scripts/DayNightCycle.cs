using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Range(0f, 1f)]
    public float time;
    public float fullDayLenght;
    public float startTime = 0.4f;

    private float timeRate;
    public Vector3 noon;

    [Header("Sun")]
    public Light sun;
    public Gradient sunColor;
    public AnimationCurve sunIntensity;

    [Header("Moon")]
    public Light moon;
    public Gradient moonColor;
    public AnimationCurve moonIntensity;

    [Header("Other l8ighting settings")]
    public AnimationCurve lightingIntensituyMultiplier;
    public AnimationCurve reflectionsIntensituyMultiplier;

    private void Start()
    {
        timeRate = 1f / fullDayLenght;
        time = startTime;
    }

    private void Update()
    {
        // increment time
        time += timeRate * Time.deltaTime;

        if (time >= 1f) time = 0f;

        // light rotation
        sun.transform.eulerAngles = (time - 0.25f) * noon * 4f;
        moon.transform.eulerAngles = (time - 0.75f) * noon * 4f;

        // light intensity
        sun.intensity = sunIntensity.Evaluate(time);
        moon.intensity = moonIntensity.Evaluate(time);


        sun.color = sunColor.Evaluate(time);
        moon.color = moonColor.Evaluate(time);

        if(sun.intensity <= 0 && sun.gameObject.activeInHierarchy)
        {
            sun.gameObject.SetActive(false);
        } else if (sun.intensity > 0 && !sun.gameObject.activeInHierarchy)
        {
            sun.gameObject.SetActive(true);
        }

        if (moon.intensity <= 0 && moon.gameObject.activeInHierarchy)
        {
            moon.gameObject.SetActive(false);
        }
        else if (moon.intensity > 0 && !moon.gameObject.activeInHierarchy)
        {
            moon.gameObject.SetActive(true);
        }

        RenderSettings.ambientIntensity = lightingIntensituyMultiplier.Evaluate(time);
        RenderSettings.reflectionIntensity = reflectionsIntensituyMultiplier.Evaluate(time);
    }
}
