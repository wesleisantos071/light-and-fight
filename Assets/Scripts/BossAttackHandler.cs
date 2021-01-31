using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BossAttackHandler : MonoBehaviour {
    public GameObject spitPrefab;
    public GameObject playerTarget;
    public float initialSpitTime = 4;
    float currentSpitTime;
    public float limitSpitTime = 0.8f;
    public Action onSpit;

    void Start() {
        spitPrefab.GetComponent<BossSpitHandler>().playerLight = playerTarget;
        currentSpitTime = initialSpitTime;
    }

    // Update is called once per frame
    void Update() {
        currentSpitTime -= Time.deltaTime;
        if (currentSpitTime <= 0) {
            Spit();
            currentSpitTime = initialSpitTime;
        }
    }

    void Spit() {
        GameObject spit = GameObject.Instantiate(spitPrefab);
        spit.transform.position = transform.position;
        spit.transform.parent = null;
        onSpit?.Invoke();
    }
}
