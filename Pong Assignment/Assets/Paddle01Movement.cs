using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle01Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // this is for the Left Paddle 

        float moveSpeed = 15f; // how fast its moving
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.S);
        // making the keys move Paddle01

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressing W");
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        // will move the paddle up 


        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S");
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        // will move the paddle down

    }
}

