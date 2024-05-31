using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class PlayerMovementBaseCommand : CommandBase
    {
        protected PlayerMovement playerMovement;
        public PlayerMovementBaseCommand(PlayerMovement playerMovement)
        {
            this.playerMovement = playerMovement;
        }
        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}