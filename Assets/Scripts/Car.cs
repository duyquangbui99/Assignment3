﻿using UnityEngine;


public class Car : MonoBehaviour
{

    public Rigidbody2D rb;

    public static float speed = 8f;


    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}
