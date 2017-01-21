using UnityEngine;
using System.Collections;

public class FallingFloorControl : MonoBehaviour {

    public bool WallPuzzleActive;
    FallingFallTrigger[] fft;
    public bool PathReset;

	void Start ()
    {
        WallPuzzleActive = true;
        fft = GetComponentsInChildren<FallingFallTrigger>();
    }
	
    public void ResetLevel()
    {
        foreach (var floor in fft)
        {
            floor.EnableFloor();
        }
    }

	void Update ()
    {
	
	}
}
