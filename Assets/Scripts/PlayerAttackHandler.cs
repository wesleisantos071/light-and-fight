using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerAttackHandler : MonoBehaviour {
    public Action<int> onAttack;
    public PlayerMovementHandler movementHandler;
    public BoxCollider2D attackAreaLeft;
    public BoxCollider2D attackAreaRight;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            int lastDirection = movementHandler.lastDirection;
            onAttack?.Invoke(lastDirection);
        }
    }

    public void EnableRightAttack() {
        attackAreaRight.enabled = true;
    }

    public void DisableRightAttack() {
        attackAreaRight.enabled = false;
    }

    public void EnableLeftAttack() {
        attackAreaLeft.enabled = true;
    }

    public void DisableLeftAttack() {
        attackAreaLeft.enabled = false;
    }
}
