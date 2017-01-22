using UnityEngine;
using System.Collections;

public class StandardButton : MonoBehaviour {

    public bool ButtonOn = false;
    public Material buttonOnMat, buttonOffMat;
    private MeshRenderer buttonMeshRenderer;
    [Range(1,6)]
    public int ButtonNumber;
    ButtonSequencePuzzle buttonSequencePuzzle;
    ObjectShake objectShake;

    void Start()
    {
        objectShake = GetComponent<ObjectShake>();
        buttonMeshRenderer = GetComponent<MeshRenderer>();
        buttonMeshRenderer.material = buttonOffMat;

        buttonSequencePuzzle = GetComponentInParent<ButtonSequencePuzzle>();
    }

	public void ActuateButton()
    {
        if (buttonSequencePuzzle != null)
        {
            if (!buttonSequencePuzzle.PuzzleSolved)
            {
                if (ButtonOn)
                {
                    ButtonOn = false;
                }
                else
                {
                    ButtonOn = true;
                    buttonSequencePuzzle.ReceiveNumber(ButtonNumber, objectShake);
                }
           }
        }
    }

    void Update()
    {
        if(ButtonOn && (buttonMeshRenderer.material != buttonOnMat))
        {
            buttonMeshRenderer.material = buttonOnMat;
        }
        else if (!ButtonOn && (buttonMeshRenderer.material != buttonOffMat))
        {
            buttonMeshRenderer.material = buttonOffMat;
        }
    }
}
