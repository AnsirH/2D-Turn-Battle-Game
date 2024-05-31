using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class PlayerMoveRightCommand : PlayerMovementBaseCommand
    {
        public PlayerMoveRightCommand(PlayerMovement playerMovement) : base(playerMovement)
        {
        }

        public override void Execute()
        {
            playerMovement.MoveHorizontal(PlayerMovement.Direction.Right);
            Debug.Log("MoveRight");
        }
    }
}