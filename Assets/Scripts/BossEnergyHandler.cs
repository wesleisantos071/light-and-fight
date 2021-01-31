using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BossEnergyHandler : MonoBehaviour {
    public Image bar;
    public GameObject victoryImage;
    public BossCollisionDetectionHandler collisionHandler;

    private void Start() {
        collisionHandler.onHurt += UpdateBar;
    }

    // Update is called once per frame
    void UpdateBar() {
        Debug.Log("Decreasing bar");
        bar.fillAmount -= 0.3f;
        float fill = bar.fillAmount;
        if (fill <= 0) {
            Debug.Log("Victory");
            victoryImage.SetActive(true);
        }
    }

    private void OnDestroy() {
        collisionHandler.onHurt -= UpdateBar;
    }
}
