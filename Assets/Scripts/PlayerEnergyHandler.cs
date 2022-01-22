using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerEnergyHandler : MonoBehaviour {
    public Image bar;
    public CollisionDetectionHandler collisionHandler;
    [SerializeField]
    float hitReceiveAmount = 1;
    [SerializeField]
    GameEvent eventOnGameOver;

    private void Start() {
        collisionHandler.onTouchEnemy += UpdateBar;
    }

    // Update is called once per frame
    void UpdateBar() {
        Debug.Log("Receiving hit");
        bar.fillAmount -= hitReceiveAmount;
        float fill = bar.fillAmount;
        if (fill <= 0) {
            eventOnGameOver.Raise();
        }
    }

    private void OnDestroy() {
        collisionHandler.onTouchEnemy -= UpdateBar;
    }
}
