using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCycle : MonoBehaviour
{
    Camera cam;
    [SerializeField] Color[] colors = new Color[10];
    int index = 0;
    float time = 0f;
    float delay = 5f;

    private void Update()
    {
        time = time + 1f * Time.deltaTime;
        if(time>=delay)
        {
            time = 0f;
            if (index > 9)
            {
                index = 0;
            }
            cam = GetComponent<Camera>();
            cam.backgroundColor = colors[index];
            index++;

        }
    }

    
}