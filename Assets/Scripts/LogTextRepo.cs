using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTextRepo : MonoBehaviour {

    

    public Dictionary<MasterControlScript.OrbSpecification, string> TerminalText = new Dictionary<MasterControlScript.OrbSpecification, string>();

	void Start ()
    {
        TerminalText.Add(MasterControlScript.OrbSpecification.Theta, "21-01-2142: Early tests are promising. Subject 81 has responded well with our experiments, but I can’t help but think the subject is resisting.We can’t press too hard before the incubation.The subject must remain calm through the process or we risk losing the subject.");
        TerminalText.Add(MasterControlScript.OrbSpecification.Alpha, "22-01-2142: All tests are complete now. The subject has now entered incubation. There will be enough waves here to last at least 50 years.This city will be strong again.The dark skies no longer hold us back.");
        TerminalText.Add(MasterControlScript.OrbSpecification.Beta, "23-01-2142: We’re starting to get abnormal readings. The power is erractic. Will continue to monitor.");
        TerminalText.Add(MasterControlScript.OrbSpecification.Gamma, "26-01-2142: MALFUNCTION: Subject 81 conscious. ");
    }
}
