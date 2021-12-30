using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour
{
    // Start is called before the first frame update

    bool isAMuted = false;
    Camera cam;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mutea()
    {
        if (!isAMuted)
        {
            isAMuted = true;
            cam = FindObjectOfType<Camera>();
            cam.GetComponent<AudioSource>().Pause();
        }
        else
        {
            isAMuted = false;
            cam = FindObjectOfType<Camera>();
            cam.GetComponent<AudioSource>().UnPause();
        }
    }

    private void Awake()
    {     
        if (isAMuted == true)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void resetgame()
    {
        Destroy(gameObject);
    }
}
