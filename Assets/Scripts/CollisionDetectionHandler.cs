using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionHandler : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("EnemyL1")) {
            Debug.Log("Ouch!");
        }
    }
}
