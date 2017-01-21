using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FPSPlayerControl : MonoBehaviour
{

    private RaycastHit hit;
    private Camera fpsCam;
    public Image Crosshair;
    public Texture ActiveCrosshair, NormalCrosshair;
    private bool ActiveCrosshairSet = false;
    Rect crosshairRect;
    Rect distanceToAudioSourceMeter;
    private Texture crosshairToDraw;
    StandardButton sb;
    LogTextReader logTextReader;
    OrbTrialHandler orbTrial;
    FinalPillarsHandler finalPillar;
    private RaycastHit distanceHit;
    GameUIManager gameUIManager;
    public GameObject DistanceMeasurementObject;


    void Start()
    {
        fpsCam = GetComponentInChildren<Camera>();
        gameUIManager = FindObjectOfType<GameUIManager>();
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

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, 100F))
        {
            if (hit.transform.gameObject.tag == "Clickable")
            {
                if (!ActiveCrosshairSet)
                {
                    crosshairToDraw = ActiveCrosshair;
                    ActiveCrosshairSet = true;
                }
                if (Input.GetButtonDown("Fire1"))
                {
                    sb = hit.transform.GetComponent<StandardButton>();
                    logTextReader = hit.transform.GetComponent<LogTextReader>();
                    orbTrial = hit.transform.GetComponent<OrbTrialHandler>();
                    finalPillar = hit.transform.GetComponent<FinalPillarsHandler>();
                    if (sb != null)
                    {
                        sb.ActuateButton();
                    }
                    if(logTextReader != null)
                    {
                        logTextReader.ReceiveClick();
                    }

                    if(orbTrial != null)
                    {
                        orbTrial.SetOrb();
                    }

                    if(finalPillar != null)
                    {
                        finalPillar.ReceiveOrb();
                    }
                }
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (gameUIManager.DisplayMeasurement)
            {
                gameUIManager.DisplayMeasurement = false;
            }
            else
            {
                gameUIManager.DisplayMeasurement = true;
            }
        }
    }
}
        
