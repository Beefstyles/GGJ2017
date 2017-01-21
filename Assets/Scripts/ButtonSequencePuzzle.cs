using UnityEngine;
using System.Collections;

public class ButtonSequencePuzzle : MonoBehaviour {

    public StandardButton[] sbArray;
    //Order : 3, 4, 2, 5, 1

    
	void Start ()
    {
        sbArray = GetComponentsInChildren<StandardButton>();

        foreach(StandardButton button in sbArray)
        {
            button.ButtonOn = false;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void ReceiveNumber(int numberReceived)
    {
        Debug.Log("Received " + numberReceived);
    }
}
