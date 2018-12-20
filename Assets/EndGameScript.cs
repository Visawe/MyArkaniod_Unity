using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 40;
        myStyle.normal.textColor = Color.yellow;
        GUI.Label(new Rect((Screen.width - 100) / 2, (Screen.height - 50) / 2 - 60, 100, 50), "WIN!!!", myStyle);
        if (GUI.Button(new Rect((Screen.width - 100) / 2, (Screen.height - 50) / 2, 100, 50), "Start Game"))
        {
            MainCameraScript.testGame = false;
            MainCameraScript.level = 1;
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
    }
}
