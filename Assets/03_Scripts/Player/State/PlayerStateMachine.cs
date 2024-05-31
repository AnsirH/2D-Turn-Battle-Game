using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerStateMachine
    {
        public enum PlayerStates { Idle = 0, Move, Jump, Fall }

        private PlayerController playerController;
        private StateBase<PlayerController>[] states;
        private StateBase<PlayerController> currentState;

        public PlayerStateMachine(PlayerController playerController)
        {
            this.playerController = playerController;

            states = new StateBase<PlayerController>[4];
            states[(int)PlayerStates.Idle] = new PlayerIdleState();
            states[(int)PlayerStates.Move] = new PlayerMoveState();
            states[(int)PlayerStates.Jump] = new PlayerJumpState();
            states[(int)PlayerStates.Fall] = new PlayerFallState();
        }

        public void Updated()
        {
            currentState.Operation_Update(playerController);
        }

        public void FixedUpdated()
        {
            currentState.Operation_FixedUpdate(playerController);
        }

        public void ChangeState(PlayerStates state)
        {
            if (currentState != null)
            {
                currentState.Exit(playerController);
            }
            currentState = states[(int)state];
            currentState.Enter(playerController);
        }
    }
}