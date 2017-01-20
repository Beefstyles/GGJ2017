using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FPSPlayerControl : MonoBehaviour {

    private RaycastHit hit;
    private Camera fpsCam;
    public Image Crosshair;
    public Texture ActiveCrosshair, NormalCrosshair;
    private bool ActiveCrosshairSet = false;
    Rect crosshairRect;
    private Texture crosshairToDraw;

	void Start ()
    {
        fpsCam = GetComponentInChildren<Camera>();
        crosshairToDraw = NormalCrosshair;
        float crosshairSize = Screen.width * 0.01F;
        crosshairRect = new Rect(Screen.width / 2 - crosshairSize / 2,
            Screen.height / 2 - crosshairSize / 2,
            crosshairSize, crosshairSize);
	}

    void OnGUI()
    {
        GUI.DrawTexture(crosshairRect, crosshairToDraw);
    }

    void Update()
    {
        if (ActiveCrosshairSet)
        {
            crosshairToDraw = NormalCrosshair;
            ActiveCrosshairSet = false;
        }

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward,out hit, 100F))
        {
            if(hit.transform.gameObject.tag == "Clickable")
            {
                if (!ActiveCrosshairSet)
                {
                    crosshairToDraw = ActiveCrosshair;
                    ActiveCrosshairSet = true;
                }
                if (Input.GetButtonDown("Fire1"))
                {
                    Debug.Log("Can click!");
                }
            }
        }
    }

}
