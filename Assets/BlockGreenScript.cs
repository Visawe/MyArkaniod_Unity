using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockGreenScript : MonoBehaviour {
    
    void OnCollisionEnter2D(Collision2D col)
    {
        //gameObject - это тот объект, на котором находится скрипт
        //здесь это блок
        //col.gameObject - это тот, кто врезался или наложился
        //здесь это мячик
        if (col.gameObject.tag == "ball")
        {
            MainCameraScript.score++;
            Destroy(gameObject);
        }
        string sceneName = "MainScene";
        int goalCount = 0;
        if(MainCameraScript.testGame)
        {
            goalCount = 10;
        }
        else
        {
            goalCount = MainCameraScript.countInitBlock;
        }


        if (MainCameraScript.racket == 1)
        {
            
        }

        //if (MainCameraScript.score == MainCameraScript.countInitBlock)
        if (MainCameraScript.score == goalCount)
        {
            if(MainCameraScript.level == 1)
            {
                sceneName = "SecondLevel";
                MainCameraScript.level++;
            }
            else if(MainCameraScript.level == 2)
            {
                sceneName = "ThirdLevel";
                MainCameraScript.level++;
            }
            else if(MainCameraScript.level == 3)
            {
                sceneName = "EndGame";
            }
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
