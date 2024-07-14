using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerAttackHandler : MonoBehaviour {
    public Action<int> onAttack;
    public PlayerMovementHandler movementHandler;
    public GameObject attackAreaLeft;
    public GameObject attackAreaRight;

    InputHandler inputHandler;

    private void Awake() {
        inputHandler = new InputHandler();
        inputHandler.Player.Action.performed += ctx => Attack();
    }

    private void OnEnable() {
        inputHandler.Enable();
    }

    private void OnDisable() {
        inputHandler.Disable();
    }

    void Attack() {
        onAttack?.Invoke(1);
        attackAreaRight.SetActive(true);
    }

    public void DisableRightAttack() {
        attackAreaRight.SetActive(false);
    }

    public void DisableLeftAttack() {
        attackAreaLeft.SetActive(false);
    }
}
