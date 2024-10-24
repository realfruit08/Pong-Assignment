using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle02Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this is for the Right Paddle
        float moveSpeed = 15f; // how fast its moving 
        Input.GetKey(KeyCode.UpArrow);
        Input.GetKey(KeyCode.DownArrow);
        // making the keys move Paddle02

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pressing UpArrow");
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        // will move paddle up 

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Pressing DownArrow");
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        // will move paddle down
    }
}