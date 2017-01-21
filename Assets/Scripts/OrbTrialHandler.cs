using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTrialHandler : MonoBehaviour {

    public MasterControlScript.OrbSpecification orbSpec;
    PlayerInventory playerInventory;

    void Start()
    {
        playerInventory = FindObjectOfType<PlayerInventory>();
    }
    public void SetOrb()
    {
            switch (orbSpec)
            {
                case (MasterControlScript.OrbSpecification.Alpha):
                    if (!playerInventory.haveAlphaOrb)
                    {
                        playerInventory.haveAlphaOrb = true;
                        gameObject.SetActive(false);
                    }
                    break;
                case (MasterControlScript.OrbSpecification.Beta):
                    if (!playerInventory.haveBetaOrb)
                    {
                    playerInventory.haveBetaOrb = true;
                    gameObject.SetActive(false);
                }
                    break;
                case (MasterControlScript.OrbSpecification.Gamma):
                    if (!playerInventory.haveGammaOrb)
                    {
                        playerInventory.haveGammaOrb = true;
                    gameObject.SetActive(false);
                }
                    break;
                case (MasterControlScript.OrbSpecification.Theta):
                    if (!playerInventory.haveThetaOrb)
                    {
                     playerInventory.haveThetaOrb = true;
                    gameObject.SetActive(false);
                }
                    break;
            }
        }
    }

