using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightAnimationController : MonoBehaviour {
    public PlayerMovementHandler playerMovement;
    public CollisionDetectionHandler collisionHandler;
    public Animator anim;

    // Start is called before the first frame update
    void Start() {
        playerMovement.onJump += OnJump;
        playerMovement.onWalk += OnWalk;
        collisionHandler.onTouchGround += OnGround;
        collisionHandler.onTouchEnemy += OnHurt;
    }

    void OnJump() {
        anim.SetBool("jumping", true);
    }

    void OnWalk(int direction) {
        bool wRight = false;
        bool wLeft = false;
        switch (direction) {
            case 1:
                wRight = true;
                break;
            case -1:
                wLeft = true;
                break;
            default:
                break;
        }
        anim.SetBool("walking_right", wRight);
        anim.SetBool("walking_left", wLeft);
    }

    void OnGround() {
        Debug.Log("OnGround called");
        anim.SetBool("jumping", false);
    }

    void OnHurt() {
        anim.SetTrigger("hurt");
    }

    private void OnDestroy() {
        playerMovement.onJump -= OnJump;
        playerMovement.onWalk -= OnWalk;
        collisionHandler.onTouchGround -= OnGround;
        collisionHandler.onTouchEnemy -= OnHurt;
    }
}
