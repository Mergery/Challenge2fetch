using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;  // i am replacing it from 30 to -30
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)  // i have changed > to <
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit) // changed from Z to y
        {
            Debug.Log( " Game Over!!!");    // if ball fall beneath limit it displays game over for user
            Destroy(gameObject);
        }

    }
}
