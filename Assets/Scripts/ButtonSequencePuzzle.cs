﻿using UnityEngine;
using System.Collections;

public class ButtonSequencePuzzle : MonoBehaviour {

    public StandardButton[] sbArray;
    public ObjectShake[] oShakeArray;
    //Order : 3, 4, 2, 5, 1
    
    public int NumberOfButtonsInPuzzle;
    int[] orderArray;
    int[] correctOrderArray;
    int orderArrayPosition = 0;
    public bool PuzzleSolved = false;

	void Start ()
    {
        orderArray = new int[NumberOfButtonsInPuzzle];
        correctOrderArray = new int[4] { 3, 4, 2, 1};
        sbArray = GetComponentsInChildren<StandardButton>();
        oShakeArray = GetComponentsInChildren<ObjectShake>();

        ResetButtons();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    private void ResetButtons()
    {
        foreach (StandardButton button in sbArray)
        {
            button.ButtonOn = false;
            
        }

        foreach (var shakeObj in oShakeArray)
        {
            shakeObj.StartShake(false);
        }
    }

    public void ReceiveNumber(int numberReceived, ObjectShake os)
    {
        orderArray[orderArrayPosition] = numberReceived;
        switch (orderArrayPosition)
        {
            case (0):
                if(orderArray[orderArrayPosition] == correctOrderArray[orderArrayPosition])
                {
                    orderArrayPosition++;
                    Debug.Log(orderArrayPosition);
                    os.StartShake(true);
                }
                else
                {
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
            case (1):
                if (orderArray[orderArrayPosition] == correctOrderArray[orderArrayPosition])
                {
                    orderArrayPosition++;
                    Debug.Log(orderArrayPosition);
                    os.StartShake(true);
                }
                else
                {
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
            case (2):
                if (orderArray[orderArrayPosition] == correctOrderArray[orderArrayPosition])
                {
                    orderArrayPosition++;
                    Debug.Log(orderArrayPosition);
                    os.StartShake(true);
                }
                else
                {
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
            case (3):
                if (orderArray[orderArrayPosition] == correctOrderArray[orderArrayPosition])
                {
                    os.StartShake(true);
                    Debug.Log(orderArrayPosition);
                    Debug.Log("Correct!");
                    Debug.Log("Puzzle Solved!");
                    PuzzleSolved = true;
                }
                else
                {
                    Debug.Log("Wrong");
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
        }
    }
}
