using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTextRepo : MonoBehaviour {

    public enum TerminalNumber
    {
        Terminal1, Terminal2, Terminal3, Terminal4
    };

    public Dictionary<TerminalNumber, string> TerminalText = new Dictionary<TerminalNumber, string>();

	void Start ()
    {
        TerminalText.Add(TerminalNumber.Terminal1,"20-01-2142: Subject 81 arrived today.Subject 81 hasn’t regained consciousness yet.Still breathing though.Tests will be done before the subject awakes. If Subject 81 remembers the past, then they won’t be any use to us. It’s taken a long time to find this one.We think there’s enough potential here to last us a long time.");
        TerminalText.Add(TerminalNumber.Terminal2, "21-01-2142: Early tests are promising.Subject 81 has responded well with our experiments, but I can’t help but think the subject is resisting.We can’t press too hard before the incubation.The subject must remain calm through the process or we risk losing the subject.");
        TerminalText.Add(TerminalNumber.Terminal3, "22 - 01 - 2142: All tests are complete now.The subject has now entered incubation.There will be enough waves here to last at least 50 years.This city will be strong again.The dark skies no longer hold us back.");
        TerminalText.Add(TerminalNumber.Terminal4, "26-01-2142:MALFUNCTION: Subject 81 conscious.");
    }
	
	void Update ()
    {
		
	}
}
