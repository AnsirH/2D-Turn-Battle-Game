using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class PlayerMoveStopCommand : PlayerMovementBaseCommand
    {
        public PlayerMoveStopCommand(PlayerMovement playerMovement) : base(playerMovement)
        {
        }

        public override void Execute()
        {
            playerMovement.MoveHorizontal(PlayerMovement.Direction.Stop);
        }
    }
}