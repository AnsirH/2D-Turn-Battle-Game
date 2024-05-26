using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerInputGetter : MonoBehaviour
{
    private Vector2 moveInput;
    private bool isJump;
    private InputAction inputAction;

    public Vector2 MoveInput => moveInput;
    public bool IsMove { get { return !Mathf.Approximately(moveInput.x, 0.0f); } }
    public bool IsJump => isJump;

    public void DisableJump() { isJump = false; }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log($"{moveInput.x} {moveInput.y}");
    }

    void OnJump()
    {
        isJump = true;
    }
}
