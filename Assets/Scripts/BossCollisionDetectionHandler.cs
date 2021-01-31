using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BossCollisionDetectionHandler : MonoBehaviour {

    public Action onHurt;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("collided with" + collision.tag);
        if (collision.name.Equals("PlayerAttack")) {
            onHurt?.Invoke();
        }
    }
}
