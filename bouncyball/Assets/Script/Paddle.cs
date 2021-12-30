using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float max;
    [SerializeField] float min;
    [SerializeField] float width;
    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            Vector3 paddlepos = new Vector3(transform.position.x + t.deltaPosition.x * .02f, transform.position.y, transform.position.z);
            paddlepos.x = Mathf.Clamp(paddlepos.x, min, max);
            transform.position = paddlepos;
        }
    }

}