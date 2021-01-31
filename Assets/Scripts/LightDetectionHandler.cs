using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDetectionHandler : MonoBehaviour {
    GameObject player2;
    public GameObject Body;
    BoxCollider2D bc;
    bool onShadow = true;
    public bool debugLine = false;
    void Start() {
        player2 = GameObject.FindGameObjectWithTag("Player2");
        bc = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate() {
        Vector2 tgt = player2.transform.position - transform.position;
        int layerMask = ~(LayerMask.GetMask("NonLight"));
        RaycastHit2D hit = Physics2D.Raycast(transform.position, tgt, 1000, layerMask);
        if (hit) {
            onShadow = !hit.transform.gameObject.CompareTag(player2.tag);
            Body.SetActive(onShadow);
            bc.enabled = onShadow;
            if (debugLine)
                Debug.DrawRay(transform.position, tgt, Color.green);
        }
    }
}
