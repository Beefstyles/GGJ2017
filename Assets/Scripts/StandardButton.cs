using UnityEngine;
using System.Collections;

public class StandardButton : MonoBehaviour {

    private bool buttonOn = false;
    public Material buttonOnMat, buttonOffMat;
    private MeshRenderer buttonMeshRenderer;

    void Start()
    {
        buttonMeshRenderer = GetComponent<MeshRenderer>();
        buttonMeshRenderer.material = buttonOffMat;
    }

	public void ActuateButton()
    {
        if (buttonOn)
        {
            buttonMeshRenderer.material = buttonOffMat;
            buttonOn = false;
        }
        else
        {
            buttonMeshRenderer.material = buttonOnMat;
            buttonOn = true;
        }
    }
}
