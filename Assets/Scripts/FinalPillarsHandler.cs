using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPillarsHandler : MonoBehaviour {

    public GameObject Orb;

    MasterControlScript masterControl;
    public MasterControlScript.OrbSpecification orbSpec;
    PlayerInventory playerInventory;
    TerminalTextChanger terminalTextChanger;

	// Use this for initialization
	void Start ()
    {
        masterControl = FindObjectOfType<MasterControlScript>();
        playerInventory = FindObjectOfType<PlayerInventory>();
        terminalTextChanger = FindObjectOfType<TerminalTextChanger>();
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
                        terminalTextChanger.ChangeTerminalText(MasterControlScript.OrbSpecification.Alpha);
                    }
                    break;
                case (MasterControlScript.OrbSpecification.Beta):
                    if (playerInventory.haveBetaOrb)
                    {
                        Orb.SetActive(true);
                        masterControl.BetaOrbSet = true;
                        terminalTextChanger.ChangeTerminalText(MasterControlScript.OrbSpecification.Beta);
                    }
                    break;
                case (MasterControlScript.OrbSpecification.Gamma):
                    if (playerInventory.haveGammaOrb)
                    {
                        Orb.SetActive(true);
                        masterControl.GammaOrbSet = true;
                        terminalTextChanger.ChangeTerminalText(MasterControlScript.OrbSpecification.Gamma);
                    }
                    break;
                case (MasterControlScript.OrbSpecification.Theta):
                    if (playerInventory.haveThetaOrb)
                    {
                        Orb.SetActive(true);
                        masterControl.ThetaOrbSet = true;
                        terminalTextChanger.ChangeTerminalText(MasterControlScript.OrbSpecification.Theta);
                    }
                    break;
            }
        }
    }
}
