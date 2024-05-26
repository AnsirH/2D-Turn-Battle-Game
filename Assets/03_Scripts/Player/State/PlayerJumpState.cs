using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerJumpState : StateBase<PlayerController>
    {
        public override void Enter(PlayerController entity)
        {
            entity.Movement.Rigid2D.velocity = new Vector2(entity.Movement.Rigid2D.velocity.x, 0.0f);
            entity.Movement.Jump();
            entity.InputGetter.DisableJump();
            if (entity.InputGetter.IsMove) { entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Move); }
            else { entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Idle); }
            // jump animation true
        }

        public override void Exit(PlayerController entity)
        {

            // jump animation false
        }

        public override void Operation_FixedUpdate(PlayerController entity)
        {

        }

        public override void Operation_Update(PlayerController entity)
        {
        }
    }
}