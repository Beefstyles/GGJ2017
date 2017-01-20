using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FPSPlayerControl : MonoBehaviour {

    private RaycastHit hit;
    private Camera fpsCam;
    public Image Crosshair;
    public Sprite ActiveCrosshair, NormalCrosshair;
    private bool ActiveCrosshairSet = false;

	void Start ()
    {
        fpsCam = GetComponentInChildren<Camera>();
        Crosshair.sprite = NormalCrosshair;
	}

    void Update()
    {
        if (ActiveCrosshairSet)
        {
            Crosshair.sprite = NormalCrosshair;
            ActiveCrosshairSet = false;
        }

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward,out hit, 100F))
        {
            if(hit.transform.gameObject.tag == "Clickable")
            {
                if (!ActiveCrosshairSet)
                {
                    Crosshair.sprite = ActiveCrosshair;
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
