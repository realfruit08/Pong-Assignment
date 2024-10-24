using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBack : MonoBehaviour
{
   //boundry
    public float boundaryX = 8.37f;   
    public float boundaryX2 = -8.37f; 
    public Vector3 centerPosition;
    void Start()
    {
        centerPosition = new Vector3(0, 0, 0);
    }
    void Update()
    {
        if (transform.position.x < boundaryX2 || transform.position.x > boundaryX ||
            transform.position.y < -boundaryX || transform.position.y > boundaryX)
        {
            TeleportToCenter();
        }
    }
    void TeleportToCenter()
    {
        transform.position = centerPosition;
    }
}