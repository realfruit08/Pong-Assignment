using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector2 direction;
    float speed = 5.0f;
    void Start()
    {
        direction = Random.insideUnitCircle.normalized;
        transform.position = Vector3.zero;
        Debug.Log($"Initial Direction: {direction}");
    }
    void Update()
    {
        if (transform.position.y > 4.339f)
        {
            direction.y = -direction.y;
            transform.position = new Vector3(transform.position.x, 4.339f, transform.position.z);
        }
        if (transform.position.y < -4.34f)
        {
            direction.y = -direction.y;
            transform.position = new Vector3(transform.position.x, -4.34f, transform.position.z);
        }
        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position += change;
    }
}