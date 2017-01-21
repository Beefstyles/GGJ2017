using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FloorTimingLightsPuzzle : MonoBehaviour {

    private Light mainSpotLight;
    //Color Blue, Green, Purple,Red, Teal, Yellow

    public enum LightColours
    {
        Blue, Green, Purple, Red, Teal, Yellow
    };

    public GameObject floors;
    public FallingFloorTiming[] fallingFloorTimingObj;

    private Color32 teal = new Color32(0, 128, 128,1);
   

    private LightColours chosenLightColour;

    private float lightChangeTimer = 2F;

    void Start ()
    {
        fallingFloorTimingObj = floors.GetComponentsInChildren<FallingFloorTiming>();
        foreach(var lightFloors in fallingFloorTimingObj)
        {
            lightFloors.gameObject.SetActive(true);
        }
        mainSpotLight = GetComponentInChildren<Light>();
        mainSpotLight.color = Color.blue;
    }

	void Update ()
    {
        if(lightChangeTimer >= 0)
        {
            lightChangeTimer -= Time.deltaTime;
        }
        else
        {
            PickRandomLightColour();
            lightChangeTimer = 2;
        }
	}

    void PickRandomLightColour()
    {
        chosenLightColour = (LightColours)Random.Range(0, 6);
        ChangeLightColour(chosenLightColour);
        SendLightColour(chosenLightColour);
    }

    private void ChangeLightColour(LightColours chosenLightColour)
    {
        switch (chosenLightColour)
        {
            case (LightColours.Blue):
                mainSpotLight.color = Color.blue;
                break;
            case (LightColours.Green):
                mainSpotLight.color = Color.green;
                break;
            case (LightColours.Purple):
                mainSpotLight.color = Color.magenta;
                break;
            case (LightColours.Red):
                mainSpotLight.color = Color.red;
                break;
            case (LightColours.Teal):
                mainSpotLight.color = teal;
                break;
            case (LightColours.Yellow):
                mainSpotLight.color = Color.yellow;
                break;
        }
    }

    private void SendLightColour(LightColours chosenLightColour)
    {
        foreach(FallingFloorTiming floor in fallingFloorTimingObj)
        {
            floor.ReceiveLightColour(chosenLightColour);
        }
    }
}
