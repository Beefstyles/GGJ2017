using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalTextWrapper : MonoBehaviour {

    public TextMesh textObject;

    public int maxLineChars = 20;

    private string[] words;
    string result = "";

    private int charCount;


	void Start ()
    {
        UpdateText();
    }
	
    public void UpdateText()
    {
        FormatString(textObject.text);
    }

    void FormatString(string textToFormat)
    {
        charCount = 1;
        words = (textObject.text.Split(' '));

        for (int index = 0; index < words.Length; index++)
        {
            var word = words[index].Trim();

            if(index == 0)
            {
                result = words[0];
                textObject.text = result;       
            }
            if(index > 0)
            {
                charCount += word.Length + 1;
                if(charCount <= maxLineChars)
                {
                    result += " " + word;
                }
                else
                {
                    charCount = 0;
                    result += "\n" + word;
                }

                textObject.text = result;
            }
        }
    }
}
