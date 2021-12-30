using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    AudioMaster ad;

    private void Start()
    {
        

    }

    private void Update()
    {
        
    }
    public void changeScene()
    {
        SceneManager.LoadScene("Main");
    }
    // Update is called once per frame

    public void changeToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void changeToHome()
    {
        SceneManager.LoadScene("game over");
        FindObjectOfType<AudioMaster>().resetgame();

    }

}
