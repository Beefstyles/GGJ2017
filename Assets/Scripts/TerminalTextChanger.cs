using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalTextChanger : MonoBehaviour {

    LogTextRepo logTextRepo;
    public GameObject ThreeDText;
    private TextMesh ThreeDTextMesh;
    private string displayText;
    TerminalTextWrapper textWrapper;
    

    void Start()
    {
        logTextRepo = GetComponent<LogTextRepo>();
        ThreeDTextMesh = ThreeDText.GetComponent<TextMesh>();
        textWrapper = FindObjectOfType<TerminalTextWrapper>();

        ThreeDTextMesh.text = "20-01-2142: Subject 81 arrived today. Subject 81 hasn’t regained consciousness yet. Still breathing though.Tests will be done before the subject awakes. If Subject 81 remembers the past, then they won’t be any use to us. It’s taken a long time to find this one.We think there’s enough potential here to last us a long time.";
        textWrapper.UpdateText();
    }

    public void ChangeTerminalText(MasterControlScript.OrbSpecification orbSpec)
    {
        switch (orbSpec)
        {
            case (MasterControlScript.OrbSpecification.Alpha):
                    if (logTextRepo.TerminalText.TryGetValue(MasterControlScript.OrbSpecification.Alpha, out displayText))
                    {
                        ThreeDTextMesh.text = displayText;
                    }
                textWrapper.UpdateText();
                break;
            case (MasterControlScript.OrbSpecification.Beta):
                if (logTextRepo.TerminalText.TryGetValue(MasterControlScript.OrbSpecification.Beta, out displayText))
                {
                    ThreeDTextMesh.text = displayText;
                }
                textWrapper.UpdateText();
                break;
            case (MasterControlScript.OrbSpecification.Gamma):
                if (logTextRepo.TerminalText.TryGetValue(MasterControlScript.OrbSpecification.Gamma, out displayText))
                {
                    ThreeDTextMesh.text = displayText;
                }
                textWrapper.UpdateText();
                break;
            case (MasterControlScript.OrbSpecification.Theta):
                if (logTextRepo.TerminalText.TryGetValue(MasterControlScript.OrbSpecification.Theta, out displayText))
                {
                    ThreeDTextMesh.text = displayText;
                }
                textWrapper.UpdateText();
                break;
        }

    }


}
