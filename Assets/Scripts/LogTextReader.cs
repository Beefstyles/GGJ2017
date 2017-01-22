using UnityEngine;
using System.Collections;

public class LogTextReader : MonoBehaviour {

    //public LogTextRepo.TerminalNumber TerminalNumber;
    GameUIManager gameUIManager;
    LogTextRepo logTextRepo;

	void Start ()
    {
        gameUIManager = FindObjectOfType<GameUIManager>();
        logTextRepo = GetComponentInParent<LogTextRepo>();
    }

    public void ReceiveClick()
    {
        string logText;
        /*if(logTextRepo.TerminalText.TryGetValue(TerminalNumber,out logText))
            {
            gameUIManager.gameUIText.LogText.text = logText;
            }
            */
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
