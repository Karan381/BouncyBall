using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkad : MonoBehaviour
{
    
    int checkads = 0;
    InterstitialAdExample ad;

    public void checkMOD()
    {
        ad = FindObjectOfType<InterstitialAdExample>();
        checkads = checkads + 1;
        if(checkads % 3 == 0)
        {
            ad.LoadAd();
            ad.ShowAd();
        }
    }


    
    
}
