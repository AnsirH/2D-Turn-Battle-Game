using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerFallState : StateBase<PlayerController>
    {
        public override void Enter(PlayerController entity)
        {
            entity.SpriteManager.Anim.SetBool("IsFalling", true);
        }

        public override void Exit(PlayerController entity)
        {
            entity.SpriteManager.Anim.SetBool("IsFalling", false);
        }

        public override void Operation_FixedUpdate(PlayerController entity)
        {
        }

        public override void Operation_Update(PlayerController entity)
        {
            if (entity.Movement.Rigid2D.velocity.y < 0.0f && entity.Movement.IsGrounded)
            {
                entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Idle);
            }
        }
    }
}