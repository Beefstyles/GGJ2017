using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFloorFallingPuzzle : MonoBehaviour {

    FallingFloorControl ffc;

    void Start()
    {
        ffc = FindObjectOfType<FallingFloorControl>();

    }
	void OnTriggerEnter(Collider coll)
    {
        ffc.ResetLevel();
    }
}
