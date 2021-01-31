using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerAttackHandler : MonoBehaviour {
    public Action<int> onAttack;
    public PlayerMovementHandler movementHandler;
    public GameObject attackAreaLeft;
    public GameObject attackAreaRight;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            int lastDirection = movementHandler.lastDirection;
            onAttack?.Invoke(lastDirection);
            switch (lastDirection) {
                case 1:
                    Debug.Log("enabling right");
                    attackAreaRight.SetActive(true);
                    break;
                case -1:
                    Debug.Log("enabling left");
                    attackAreaLeft.SetActive(true);
                    break;
            }
        }
    }

    public void DisableRightAttack() {
        Debug.Log("disabling right");
        attackAreaRight.SetActive(false);
    }

    public void DisableLeftAttack() {
        Debug.Log("disabling left");
        attackAreaLeft.SetActive(false);
    }
}
