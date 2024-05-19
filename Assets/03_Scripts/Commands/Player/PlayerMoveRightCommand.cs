using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class PlayerMoveRightCommand : Command
    {
        PlayerMovement playerMovement;

        public PlayerMoveRightCommand(PlayerMovement playerMovement)
        {
            this.playerMovement = playerMovement;
        }

        public override void Execute()
        {
            playerMovement.Move(PlayerMovement.Direction.Right);
            Debug.Log("오른쪽으로 이동");
        }
    }
}
