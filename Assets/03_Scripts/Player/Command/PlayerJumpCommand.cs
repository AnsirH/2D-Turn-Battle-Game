using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

namespace Command
{
    public class PlayerJumpCommand : PlayerMovementBaseCommand
    {
        public PlayerJumpCommand(PlayerMovement playerMovement) : base(playerMovement)
        {
        }
        public override void Execute()
        {
            playerMovement.Rigid2D.velocity = new Vector2(playerMovement.Rigid2D.velocity.x, 0.0f);
            playerMovement.Jump();
        }
    }
}