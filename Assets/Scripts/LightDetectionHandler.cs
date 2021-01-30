using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDetectionHandler : MonoBehaviour {
    GameObject player2;
    SpriteRenderer sr;
    void Start() {
        player2 = GameObject.FindGameObjectWithTag("Player2");
        sr = GetComponent<SpriteRenderer>();
    }

    public LayerMask layerMask;

    private void FixedUpdate() {
        Vector2 tgt = player2.transform.position - transform.position;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, tgt);
        if (hit) {
            if (hit.transform.gameObject.CompareTag(player2.tag)) {
                sr.enabled = false;
            } else {
                sr.enabled = true;
            }
            //Debug.DrawRay(transform.position, tgt, Color.green);
        }
    }
}
