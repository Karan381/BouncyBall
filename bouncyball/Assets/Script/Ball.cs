using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{

    [Range(0.1f, 10f)] [SerializeField] float gamespeed = 1f;
    Vector3 paddleToBallVector;
    bool hasstarted = false;
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 0f;
    [SerializeField] float yPush = 15f;
    [SerializeField] float randompush = 1f;
    Rigidbody2D myrigidbody2d;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] AudioClip clip;
    int countclick = 0;


    int score = 0;
    [SerializeField] int scorechange;
    void Start()
    {
        scoreText.text = score.ToString();
        paddleToBallVector = transform.position - paddle1.transform.position;
        myrigidbody2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       
        Time.timeScale = gamespeed;
        scoreText.text = score.ToString();
        if (!hasstarted)
        {
            sticktopaddle();
            launchballonclick();
            
        }
        if(gamespeed == 1.5f)
        {
            scorechange = 3;
        }
        if (gamespeed == 2f)
        {
            scorechange = 4;
        }
    }
    private void launchballonclick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            countclick++;
            if (countclick >= 2)
            {
                hasstarted = true;
                myrigidbody2d.velocity = new Vector3(xPush, yPush, 0f);
            }
        }
    }

    private void sticktopaddle()
    {
        Vector3 paddlepos = new Vector3(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + paddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Vector3 velocityrandom = new Vector3(UnityEngine.Random.Range(-1f, randompush), UnityEngine.Random.Range(-1f, randompush),0f);
        Vector3 velocityrandomwalls = new Vector3(-2f, 0f, 0f);
        Vector3 velocityrandomwalls1 = new Vector3(2f, 0f, 0f);

        if (hasstarted && collision.gameObject.tag == "paddle")
        { 
           myrigidbody2d.velocity = new Vector3(xPush,yPush,0f) + velocityrandom;
           score = score + scorechange;
           AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
           gamespeed = gamespeed + 0.01f;

        }

        if (hasstarted && collision.gameObject.tag == "rightwall")
        {
            myrigidbody2d.velocity = velocityrandomwalls;            
        }

        if (hasstarted && collision.gameObject.tag == "leftwall")
        {
            myrigidbody2d.velocity = velocityrandomwalls1;
        }


    }


   


}
