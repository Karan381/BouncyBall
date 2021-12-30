using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bomb : MonoBehaviour
{
    [SerializeField] GameObject paddleblast;
    [SerializeField] AudioClip blastclip;
    [SerializeField] Paddle paddle11;
    Camera cam;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "paddle")
        {
            trigerblast();
            Invoke("SceneChange", 1);
        }

    }

   void SceneChange()
    {
        SceneManager.LoadScene("restart");
    }

    void trigerblast()
    {
        GameObject blast =  Instantiate(paddleblast, transform.position, transform.rotation);
        Destroy(blast, 2f);
        AudioSource.PlayClipAtPoint(blastclip, paddle11.transform.position);
        
    }

    
}
