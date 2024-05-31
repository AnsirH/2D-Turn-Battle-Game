using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class PlayerMoveLeftCommand : PlayerMovementBaseCommand
    {
        public PlayerMoveLeftCommand(PlayerMovement playerMovement) : base(playerMovement)
        {
        }

        public override void Execute()
        {
            playerMovement.MoveHorizontal(PlayerMovement.Direction.Left);
            Debug.Log("MoveLeft");
        }
    }
}