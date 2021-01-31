using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BossMovementController : MonoBehaviour {

    GameObject player2;
    public GameObject Body;
    BoxCollider2D bc;
    GameObject[] platforms;
    public float initialTimeToMove = 3;
    public float finalTimeToMove = 1;
    private float timeToMove;
    bool moving = true;
    public float platformOffsetY = 1;
    public Action onHitLight;
    public bool drawLine = true;

    void Start() {
        player2 = GameObject.FindGameObjectWithTag("Player2");
        bc = GetComponent<BoxCollider2D>();
        platforms = GameObject.FindGameObjectsWithTag("Platform");
        Debug.Log("Found :" + platforms.Length + " platforms");
        timeToMove = initialTimeToMove;
        Move();
    }

    private void FixedUpdate() {
        if (IsOnLight()) {
            if (!moving) {
                moving = true;
                StartCoroutine(DelayedMove(timeToMove));
            }
        }

    }

    private bool IsOnLight() {
        Vector2 tgt = player2.transform.position - transform.position;
        int layerMask = ~(LayerMask.GetMask("NonLight"));
        RaycastHit2D hit = Physics2D.Raycast(transform.position, tgt, 1000, layerMask);
        bool onLight = true;
        if (hit) {
            onLight = hit.transform.gameObject.CompareTag(player2.tag);
            if (onLight) {
                onHitLight?.Invoke();
            }
        }
        if (drawLine) {
            Debug.DrawRay(transform.position, tgt, Color.green);
        }
        return onLight;
    }

    IEnumerator DelayedMove(float time) {
        yield return new WaitForSeconds(time);
        Move();
    }

    private void Move() {
        GameObject go = platforms[UnityEngine.Random.Range(0, platforms.Length)];
        Vector2 platPos = go.transform.position;
        //adjust position and move to there
        Vector2 newPos = platPos + (Vector2.up * platformOffsetY);
        transform.position = newPos;
        if (!IsOnLight()) {
            moving = false; //only stop moving when not on light
        } else {
            Move();
        }
    }
}
