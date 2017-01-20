using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour {

    [System.Serializable]
    public class GameUIText
    {
        public Text DistanceToObjectText;
    }

    public GameUIText gameUIText;

    public GameObject DistanceMeasurementObject;
    private GameObject player;
    FPSPlayerControl fpsPlayerControl;
    public bool DisplayMeasurement = true;
    public GameObject DisplayMeasurementParent;


    void Start()
    {
        fpsPlayerControl = FindObjectOfType<FPSPlayerControl>();
        player = fpsPlayerControl.gameObject;
    }

    void Update()
    {
        UpdateDistanceMeasurement();
    }
    
    void UpdateDistanceMeasurement()
    {
        if (DistanceMeasurementObject != null)
        {   
            if (DisplayMeasurement)
            {
                if (!DisplayMeasurementParent.activeSelf)
                {
                    DisplayMeasurementParent.SetActive(true);
                }
                gameUIText.DistanceToObjectText.text = Mathf.Round(Vector3.Distance(DistanceMeasurementObject.transform.position, player.transform.position)).ToString();
            }
            else
            {
                if (DisplayMeasurementParent.activeSelf)
                {
                    DisplayMeasurementParent.SetActive(false);
                }
            }
        }
    }
}
