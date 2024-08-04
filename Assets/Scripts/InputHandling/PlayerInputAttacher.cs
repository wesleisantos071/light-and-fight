using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputAttacher : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerMovementHandler movementHandler;

    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
        var movementHandlers = FindObjectsOfType<PlayerMovementHandler>();
        var newJoinerPlayerIndex = playerInput.playerIndex;
        movementHandler = movementHandlers.FirstOrDefault(m => m.playerIndex == newJoinerPlayerIndex);
    }

    public void OnMove(InputAction.CallbackContext ctx) {
        movementHandler.Move(ctx.ReadValue<Vector2>());
    }

    public void OnJump() {
        movementHandler.Jump();
    }
}
