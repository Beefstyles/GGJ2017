using UnityEngine;
using System.Collections;

public class ButtonSequencePuzzle : MonoBehaviour {

    public StandardButton[] sbArray;
    //Order : 3, 4, 2, 5, 1
    public int NumberOfButtonsInPuzzle;
    int[] orderArray;
    int orderArrayPosition = 0;
    public bool PuzzleSolved = false;

	void Start ()
    {
        orderArray = new int[NumberOfButtonsInPuzzle];
        sbArray = GetComponentsInChildren<StandardButton>();
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
    }

    public void ReceiveNumber(int numberReceived)
    {
        Debug.Log("Received " + numberReceived);
        orderArray[orderArrayPosition] = numberReceived;
        switch (orderArrayPosition)
        {
            case (0):
                if(orderArray[orderArrayPosition] == 3)
                {
                    Debug.Log("Correct!");
                    orderArrayPosition++;
                    Debug.Log(orderArrayPosition);
                }
                else
                {
                    Debug.Log("Wrong");
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
            case (1):
                if (orderArray[orderArrayPosition] == 4)
                {
                    Debug.Log("Correct!");
                    orderArrayPosition++;
                    Debug.Log(orderArrayPosition);
                }
                else
                {
                    Debug.Log("Wrong");
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
            case (2):
                if (orderArray[orderArrayPosition] == 2)
                {
                    Debug.Log("Correct!");
                    orderArrayPosition++;
                    Debug.Log(orderArrayPosition);
                }
                else
                {
                    Debug.Log("Wrong");
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
            case (3):
                if (orderArray[orderArrayPosition] == 5)
                {
                    Debug.Log("Correct!");
                    orderArrayPosition++;
                    Debug.Log(orderArrayPosition);
                }
                else
                {
                    Debug.Log("Wrong");
                    orderArrayPosition = 0;
                    ResetButtons();
                }
                break;
            case (4):
                if (orderArray[orderArrayPosition] == 1)
                {
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
