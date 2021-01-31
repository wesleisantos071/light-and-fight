using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimationController : MonoBehaviour {
    public BossCollisionDetectionHandler collisionHandler;
    public BossAttackHandler attackHandler;
    public BossMovementController movementHandler;
    public Animator anim;

    // Start is called before the first frame update
    void Start() {
        attackHandler.onSpit += OnSpit;
        collisionHandler.onHurt += OnHurt;
        movementHandler.onHitLight += OnLight;
    }

    void OnSpit() {
        anim.SetTrigger("spit");
    }

    void OnHurt() {
        anim.SetTrigger("hurt");
    }

    void OnLight() {
        anim.SetTrigger("light");
    }

    private void OnDestroy() {
        attackHandler.onSpit -= OnSpit;
        collisionHandler.onHurt -= OnHurt;
        movementHandler.onHitLight -= OnLight;
    }
}
