using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStairsEnable : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator StairsDelayToOpaque()
    {
        Color currentColour;
        currentColour = transform.GetComponent<MeshRenderer>().material.color;
        for (float t = 0F; t < 10F; t += Time.deltaTime)
        {
            currentColour.a = Mathf.Lerp(0, 1, t);
            transform.GetComponent<MeshRenderer>().material.color = currentColour;
            yield return null;
        }
    }
}
