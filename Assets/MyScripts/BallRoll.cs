using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoll : MonoBehaviour
{
    public float moveSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0);

        GetComponent<Rigidbody2D>().AddForce(movement * moveSpeed);
    }
    
    
}
