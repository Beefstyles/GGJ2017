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


    void Start()
    {
        fpsPlayerControl = FindObjectOfType<FPSPlayerControl>();
        player = fpsPlayerControl.gameObject;
    }

    void Update()
    {
        UpdateDistanceMeasurement();
    }
    



private void UpdateDistanceMeasurement()
{
    if (DistanceMeasurementObject != null)
    {
        gameUIText.DistanceToObjectText.text = Mathf.Round(Vector3.Distance(DistanceMeasurementObject.transform.position, player.transform.position)).ToString();
    }
}
}
