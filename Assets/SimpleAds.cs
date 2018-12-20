using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements; // доступен после подключения в учетной записи  рекламы

public class SimpleAds : MonoBehaviour
{

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            //if(PlayerPrefs.GetInt("noads")!=1) 
            {
                Advertisement.Show();
                //PlayerPrefs.SetInt("DC",0); 
            }

        }
    }
}
