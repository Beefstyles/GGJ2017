using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPillarsHandler : MonoBehaviour {

    public GameObject Orb;

    MasterControlScript masterControl;
    public MasterControlScript.OrbSpecification orbSpec;
    PlayerInventory playerInventory;

	// Use this for initialization
	void Start ()
    {
        masterControl = FindObjectOfType<MasterControlScript>();
        playerInventory = FindObjectOfType<PlayerInventory>();
    }
	
	void Update ()
    {
		
	}

    public void ReceiveOrb()
    {
        if (!Orb.activeSelf)
        {
           
            switch (orbSpec)
            {
                case (MasterControlScript.OrbSpecification.Alpha):
                    if (playerInventory.haveAlphaOrb)
                    {
                        Orb.SetActive(true);
                        masterControl.AlphaOrbSet = true;
                    }
                    break;
                case (MasterControlScript.OrbSpecification.Beta):
                    if (playerInventory.haveBetaOrb)
                    {
                        Orb.SetActive(true);
                        masterControl.BetaOrbSet = true;
                    }
                    break;
                case (MasterControlScript.OrbSpecification.Gamma):
                    if (playerInventory.haveGammaOrb)
                    {
                        Orb.SetActive(true);
                        masterControl.GammaOrbSet = true;
                    }
                    break;
                case (MasterControlScript.OrbSpecification.Theta):
                    if (playerInventory.haveThetaOrb)
                    {
                        Orb.SetActive(true);
                        masterControl.ThetaOrbSet = true;
                    }
                    break;
            }
        }
    }
}
