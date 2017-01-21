using UnityEngine;
using System.Collections;

public class StandardButton : MonoBehaviour {

    public bool ButtonOn = false;
    public Material buttonOnMat, buttonOffMat;
    private MeshRenderer buttonMeshRenderer;
    [Range(0,10)]
    public int ButtonNumber;
    ButtonSequencePuzzle buttonSequencePuzzle;

    void Start()
    {
        buttonMeshRenderer = GetComponent<MeshRenderer>();
        buttonMeshRenderer.material = buttonOffMat;

        buttonSequencePuzzle = GetComponentInParent<ButtonSequencePuzzle>();
    }

	public void ActuateButton()
    {
        if (ButtonOn)
        {            
            ButtonOn = false;
        }
        else
        {
            ButtonOn = true;
            if(buttonSequencePuzzle != null)
            {
                buttonSequencePuzzle.ReceiveNumber(ButtonNumber);
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
