using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsRestartToStart : MonoBehaviour {

    public float maxTimer = 12F;

    void Update()
    {
        if(maxTimer >= 0)
        {
            maxTimer -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

}
