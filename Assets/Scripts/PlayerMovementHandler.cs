using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine.InputSystem;

public class PlayerMovementHandler : MonoBehaviour {
    public float speed = 10;
    public float jumpForce = 10;
    public int playerIndex = 0;

    private Vector2 movementInput;

    public Action onJump;
    public Action<int> onWalk;

    Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        int direction = 0;
        if (movementInput.x != 0) {
            direction = movementInput.x > 0 ? 1 : -1;
            transform.Translate(new Vector3(movementInput.x, 0, 0) * speed * Time.deltaTime);
        }
        onWalk?.Invoke(direction);
    }

    public void Move(Vector2 movementDirection) {
        movementInput = movementDirection;
     }

    public void Jump() {
        onJump?.Invoke();
        rb.velocity = Vector2.up * jumpForce;
        onJump?.Invoke();
    }

}
