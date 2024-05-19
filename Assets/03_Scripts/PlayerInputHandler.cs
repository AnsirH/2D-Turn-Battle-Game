using Command;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    Command.Command moveLeft, moveRight;
    PlayerMovement movement;
    PlayerCommandInvoker invoker;
    // Start is called before the first frame update
    void Start()
    {
        movement = TryGetComponent<PlayerMovement>(out movement) ? movement : gameObject.AddComponent<PlayerMovement>();
        invoker = TryGetComponent<PlayerCommandInvoker>(out invoker) ? invoker : gameObject.AddComponent<PlayerCommandInvoker>();

        moveLeft = new Command.PlayerMoveLeftCommand(movement);
        moveRight = new Command.PlayerMoveRightCommand(movement);
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput();
    }

    void MoveInput()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0) invoker.ExecuteCommand(moveRight);
        else if (horizontal < 0) invoker.ExecuteCommand(moveLeft);
    }
}
