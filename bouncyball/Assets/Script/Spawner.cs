using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    float nextSpawnTime;
    [SerializeField] float delay = 5;
    Camera cam;
    bool hasStarted = false;
    GameObject bomb1;
    

    private void Start()
    {
        hasStarted = true;
    }


    void Update()
    {

        if (hasStarted == true)
        {
            Invoke("changehasStarted", 5);
            
        }

        else
        {
           if (ShouldSpawn())
             {
               Spawn();
             }
        }
       
    }

   
    void Spawn()
    {
        cam = FindObjectOfType<Camera>();
        MeshCollider meshc = cam.GetComponent<MeshCollider>();
        float screenx, screeny;
        screenx = Random.Range(meshc.bounds.min.x, meshc.bounds.max.x);
        screeny = Random.Range(meshc.bounds.min.y, meshc.bounds.max.y);
        Vector2 spawnArea = new Vector2(screenx,screeny);
        nextSpawnTime = Time.time + delay;
        bomb1=Instantiate(bomb, spawnArea, transform.rotation);
        Invoke("Destroybomb", 5);
    }
    
    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
    
    void changehasStarted()
    {
        hasStarted = false;
    }

    


    void Destroybomb()
    {
        Destroy(bomb1);
    }




















    /* private void spawnobjects()
    {
        int a=1;
        cam = FindObjectOfType<Camera>();
        MeshCollider meshc = cam.GetComponent<MeshCollider>();
        float screenx, screeny;
        if (a == 1)
        {
            screenx = Random.Range(meshc.bounds.min.x, meshc.bounds.max.x);
            screeny = Random.Range(meshc.bounds.min.y, meshc.bounds.max.y);
            Vector2 Pos = new Vector2(screenx, screeny);
            Instantiate(bomb, Pos, bomb.transform.rotation);
        }
        a = 0;
    }
    // Update is called once per frame


    private void Destroyobject()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("spawnable"))
        {
            Destroy(o);
        }
    }*/
}
