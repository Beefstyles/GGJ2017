using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public float ShakeDuration = 0F;
    public float ShakeAmount = 0.7F;

    public float DecreaseFactor = 1.0F;

    Vector3 originalPostion;

    void OnEnable()
    {
        originalPostion = transform.localPosition;
    }

    void Update()
    {
        if(ShakeDuration > 0)
        {
            transform.localPosition = originalPostion + Random.insideUnitSphere * ShakeAmount;

            ShakeDuration -= Time.deltaTime * DecreaseFactor;
        }
        else
        {
            ShakeDuration = 0F;
            transform.position = originalPostion;
        }
    }
}
