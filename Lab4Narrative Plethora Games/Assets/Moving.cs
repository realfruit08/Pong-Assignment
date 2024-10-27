using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        float moveSpeed = 5f;
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.A);
        Input.GetKey(KeyCode.S);
        Input.GetKey(KeyCode.D);
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressing W");
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressing A");
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S");
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressing D");
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
            spriteRenderer.flipX = false; 
        else if (Input.GetKey(KeyCode.A))
            spriteRenderer.flipX = true; 
    }
}
