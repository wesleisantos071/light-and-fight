using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerMovementHandler : MonoBehaviour {
    public float speed = 10;
    public float jumpForce = 10;
    [HideInInspector]
    public int lastDirection = 1;

    Rigidbody2D rb;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    public Action onJump;
    public Action<int> onWalk;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        int horizontal = ReadHorizontal();
        if (horizontal != 0) {
            MoveHorizontal(horizontal);
        }
        ReadJump();
    }

    private void MoveHorizontal(int direction) {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }

    private void ReadJump() {
        if (Input.GetKeyDown(jump)) {
            rb.velocity = Vector2.up * jumpForce;
            onJump?.Invoke();
        }
    }

    private int ReadHorizontal() {
        int horizontal = 0;
        if (Input.GetKey(left)) {
            horizontal = -1;
            lastDirection = horizontal;
        } else if (Input.GetKey(right)) {
            horizontal = 1;
            lastDirection = horizontal;
        }
        onWalk?.Invoke(horizontal);
        return horizontal;
    }
}
