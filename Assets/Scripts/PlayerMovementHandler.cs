using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHandler : MonoBehaviour {
    public float speed = 10;
    public float jumpForce = 10;

    Rigidbody2D rb;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        int horizontal = ReadHorizontal();
        MoveHorizontal(horizontal);
        ReadJump();
    }

    private void MoveHorizontal(int direction) {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }

    private void ReadJump() {
        if (Input.GetKeyDown(jump)) {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private int ReadHorizontal() {
        int horizontal = 0;
        if (Input.GetKey(left)) {
            horizontal = -1;
        } else if (Input.GetKey(right)) {
            horizontal = 1;
        }
        return horizontal;
    }
}
