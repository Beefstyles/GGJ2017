using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterControlScript : MonoBehaviour {

    public enum OrbSpecification
    {
        Theta, Alpha, Beta, Gamma
    };

    public bool ThetaOrbSet, AlphaOrbSet, BetaOrbSet, GammaOrbSet;

    public bool betaRoomOpen, gammaRoomOpen, alphaRoomOpen;
    private bool openedBetaRoom, openedGammaRoom, openedAlphaRoom;

    public GameObject BetaRoomDoors, GammaRoomDoors, AlphaRoomDoors;

    

    void Start()
    {
        betaRoomOpen = false;
        gammaRoomOpen = false;
        alphaRoomOpen = false;

        openedBetaRoom = false;
        openedGammaRoom = false;
        openedAlphaRoom = false;
    }

    void Update()
    {
        if (ThetaOrbSet && !alphaRoomOpen)
        {
            alphaRoomOpen = true;
        }
        if (alphaRoomOpen && !openedAlphaRoom)
        {
            AlphaRoomDoors.SetActive(false);
            openedAlphaRoom = true;
        }

        if (AlphaOrbSet && !betaRoomOpen)
        {
            betaRoomOpen = true;
        }
        if (betaRoomOpen && !openedBetaRoom)
        {
            BetaRoomDoors.SetActive(false);
            openedBetaRoom = true;
        }

        if (BetaOrbSet && !gammaRoomOpen)
        {
            gammaRoomOpen = true;
        }
        if (gammaRoomOpen && !openedGammaRoom)
        {
            GammaRoomDoors.SetActive(false);
            openedGammaRoom = true;
        }

        if (GammaOrbSet)
        {
            GoToCredits();
        }
    }

    void GoToCredits()
    {
        SceneManager.LoadScene(2);
    }
}
