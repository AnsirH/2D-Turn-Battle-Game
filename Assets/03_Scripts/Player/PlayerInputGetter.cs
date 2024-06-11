using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputGetter : MonoBehaviour
{
    private Vector2 moveInput;
    private bool isJump;
    private InputAction inputAction;
    private PlayerInput playerInput;

    public Vector2 MoveInput => moveInput;
    public bool IsMove { get { return !Mathf.Approximately(moveInput.x, 0.0f); } }
    public bool IsJump => isJump;
    public PlayerInput PlayerInput => playerInput;

    public void DisableJump() { isJump = false; }

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.action.WasPressedThisFrame())
        {
            isJump = true;
        }

        if (context.action.WasReleasedThisFrame())
        {
            isJump = false;
        }
    }
}
