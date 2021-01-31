using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerEnergyHandler : MonoBehaviour {
    public Image bar;
    public GameObject gameoverImage;
    public CollisionDetectionHandler collisionHandler;

    private void Start() {
        collisionHandler.onTouchEnemy += UpdateBar;
    }

    // Update is called once per frame
    void UpdateBar() {
        bar.fillAmount -= 0.01f;
        float fill = bar.fillAmount;
        if (fill <= 0) {
            Debug.Log("gameover");
            gameoverImage.SetActive(true);
        }
    }

    private void OnDestroy() {
        collisionHandler.onTouchEnemy -= UpdateBar;
    }
}
