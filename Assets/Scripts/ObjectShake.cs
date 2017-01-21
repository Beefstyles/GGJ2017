using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShake : MonoBehaviour {

    public float ShakeDuration = 0F;
    public float ShakeAmount = 0.01F;

    public float DecreaseFactor = 1.0F;
    private bool shakeObject = false;

    Vector3 originalPostion;

    void OnEnable()
    {
        originalPostion = transform.localPosition;
    }

    void Update()
    {
        if (shakeObject)
        {
            if (ShakeDuration > 0)
            {
                transform.localPosition = originalPostion + Random.insideUnitSphere * ShakeAmount;

                ShakeDuration -= Time.deltaTime * DecreaseFactor;
            }
            else
            {
                //ShakeDuration = 0F;
                ShakeDuration = 1F;
                transform.position = originalPostion;
            }
        }
        else
        {
            ShakeDuration = 0F;
        }
    }

    public void StartShake(bool startToShake)
    {
        if (startToShake)
        {
            shakeObject = true;
        }
        else
        {
            shakeObject = false;
        }
    }
}
