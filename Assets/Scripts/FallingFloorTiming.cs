using UnityEngine;
using System.Collections;

public class FallingFloorTiming : MonoBehaviour {

    //Color Blue, Green, Purple,Red, Teal, Yellow

    public FloorTimingLightsPuzzle.LightColours lc;
    private bool floorIsActive = true;

    public void ReceiveLightColour(FloorTimingLightsPuzzle.LightColours lightColour)
    {
        if(lightColour == lc)
        {
            FloorDelayToTransparentAndBack(true);
            floorIsActive = true;
        }
        else
        {
            if (floorIsActive)
            {
                FloorDelayToTransparentAndBack(false);
            }
        }
    }


    IEnumerator FloorDelayToTransparentAndBack(bool floorEnabled)
    {
        float alpha = transform.GetComponent<MeshRenderer>().material.color.a;
        Color currentColour;
        currentColour = transform.GetComponent<MeshRenderer>().material.color;
        if (!floorEnabled)
        {
            for (float t = 0F; t < 0.5; t += Time.deltaTime)
            {
                currentColour.a = Mathf.Lerp(alpha, 0, t);
                transform.GetComponent<MeshRenderer>().material.color = currentColour;
                yield return null;
            }
            DisableFloor();
        }

        else
        {
            for (float t = 0F; t < .5; t += Time.deltaTime)
            {
                currentColour.a = Mathf.Lerp(0, alpha, t);
                transform.GetComponent<MeshRenderer>().material.color = currentColour;
                yield return null;
            }
            EnableFloor();
        }
    }

    void DisableFloor()
    {
        gameObject.SetActive(false);
    }

    void EnableFloor()
    {
        gameObject.SetActive(true);
    }
}
