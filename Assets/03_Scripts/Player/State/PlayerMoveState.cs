using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerMoveState : StateBase<PlayerController>
    {
        public override void Enter(PlayerController entity)
        {
            // move animation true
        }

        public override void Exit(PlayerController entity)
        {
            // move animation false
        }

        public override void Operation_FixedUpdate(PlayerController entity)
        {
            entity.Movement.MoveHorizontal(entity.InputGetter.MoveInput.x);
        }

        public override void Operation_Update(PlayerController entity)
        {
            if (!entity.InputGetter.IsMove)
            {
                entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Idle);
            }
            if (entity.InputGetter.IsJump)
            {
                entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Jump);
            }
        }
    }
}