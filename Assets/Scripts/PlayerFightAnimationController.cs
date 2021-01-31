using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFightAnimationController : MonoBehaviour {
    public PlayerMovementHandler playerMovement;
    public CollisionDetectionHandler collisionHandler;
    public PlayerAttackHandler attackHandler;
    public Animator anim;

    // Start is called before the first frame update
    void Start() {
        playerMovement.onJump += OnJump;
        playerMovement.onWalk += OnWalk;
        collisionHandler.onTouchGround += OnGround;
        attackHandler.onAttack += OnAttack;
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
        anim.SetBool("jumping", false);
    }

    void OnAttack(int direction) {
        bool aRight = false;
        bool aLeft = false;
        switch (direction) {
            case 1:
                aRight = true;
                break;
            case -1:
                aLeft = true;
                break;
            default:
                break;
        }
        anim.SetBool("attackRight", aRight);
        anim.SetBool("attackLeft", aLeft);
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
