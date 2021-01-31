using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpitHandler : MonoBehaviour {
    public GameObject playerLight;
    public float speed = 1;

    // Update is called once per frame
    void Update() {
        if (playerLight != null) {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, playerLight.transform.position, step);
            Rotate();
        }
    }

    void Rotate() {
        float rotationSpeed = 10f;
        float offset = -160f;
        Vector3 direction = playerLight.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle + offset, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag.Contains("Player")) {
            Destroy(gameObject);
        }
    }
}
