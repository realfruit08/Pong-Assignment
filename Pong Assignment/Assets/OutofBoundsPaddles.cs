using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class OutofBoundsPaddles : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxYPosition = 3.27f;//will keep paddles above the top of the screen
    public float minYPosition = -3.28f; //will keep paddles above the bottom of the screen 
    // paddles 01 and 02 should be at x-7 and x7 respectively
    void Update()
    {
        Vector3 position = transform.position;
        if (position.y > maxYPosition)
        {
            position.y = maxYPosition;
            transform.position = position;
        }
        if (position.y < minYPosition)
        {
            position.y = minYPosition;
            transform.position = position;
        }
    }
}

