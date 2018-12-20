using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect((Screen.width - 100) / 2, (Screen.height - 50)/ 2 - 60, 100, 50),
            "Start preview"))
        {
            MainCameraScript.testGame = true;
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }

        if (GUI.Button(new Rect((Screen.width - 100) / 2, (Screen.height - 50) / 2, 100, 50), "Start Game"))
        {
            MainCameraScript.testGame = false;
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
        

    }
}
