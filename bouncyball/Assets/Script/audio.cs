using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    Camera cam;
    bool isMuted = false;


    // Start is called before the first frame update
    public void AudioMute()
    {
        if (isMuted == false)
        {

            cam = FindObjectOfType<Camera>();
            cam.GetComponent<AudioSource>().Pause();
            isMuted = true;
        }
        else
        {

            cam = FindObjectOfType<Camera>();
            cam.GetComponent<AudioSource>().UnPause();
            isMuted = false;
        }

    }
}
