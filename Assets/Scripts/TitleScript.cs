using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour {

	public void EnterGame()
	{
		SceneManager.LoadScene (1);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
