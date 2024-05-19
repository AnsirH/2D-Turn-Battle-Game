using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Command
{
    public class PlayerMoveLeftCommand : Command
    {
        PlayerMovement playerMovement;

        public PlayerMoveLeftCommand(PlayerMovement playerMovement)
        {
            this.playerMovement = playerMovement;
        }

        public override void Execute()
        {
            playerMovement.Move(PlayerMovement.Direction.Left);
            Debug.Log("왼쪽으로 이동");
        }
    }
}