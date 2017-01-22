using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerRestartGame : MonoBehaviour {


    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
	// Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
