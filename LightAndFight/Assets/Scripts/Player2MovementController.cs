using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2MovementController : MonoBehaviour {

    public float speed = 10;
    public float jumpForce = 10;

    Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float horizontal = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            horizontal = -1;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            horizontal = 1;
        }
        transform.position += Vector3.right * horizontal * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
