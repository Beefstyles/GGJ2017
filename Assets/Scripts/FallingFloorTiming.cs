using UnityEngine;
using System.Collections;

public class FallingFloorTiming : MonoBehaviour {

    //Color Blue, Green, Purple, Red, Teal, Yellow

    public FloorTimingLightsPuzzle.LightColours lc;
    private bool floorIsActive = true;

    
    public void ReceiveLightColour(FloorTimingLightsPuzzle.LightColours lightColour)
    {
        if(lightColour == lc)
        {
            FloorDelayToTransparentAndBack(false);
            floorIsActive = false;
        }
        else
        {
            if (!floorIsActive)
            {
                FloorDelayToTransparentAndBack(true);
                floorIsActive = true;
            }
        }
    }

    void FloorDelayToTransparentAndBack(bool enableFloor)
    {
        if (!enableFloor)
        {
            DisableFloor();
        }
        else
        {
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
