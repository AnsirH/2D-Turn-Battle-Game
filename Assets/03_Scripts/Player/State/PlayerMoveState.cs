using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerMoveState : StateBase<PlayerController>
    {
        public override void Enter(PlayerController entity)
        {
            entity.SpriteManager.Anim.SetBool("IsMove", true);
        }

        public override void Exit(PlayerController entity)
        {
            entity.SpriteManager.Anim.SetBool("IsMove", false);
        }

        public override void Operation_FixedUpdate(PlayerController entity)
        {
            if (entity.InputGetter.MoveInput.x > 0)
            {
                entity.CommandInvoker.Execute(Command.PlayerCommandInvoker.Commands.MoveRight);
            }
            else if (entity.InputGetter.MoveInput.x < 0)
            {
                entity.CommandInvoker.Execute(Command.PlayerCommandInvoker.Commands.MoveLeft);
            }
        }

        public override void Operation_Update(PlayerController entity)
        {
            if (entity.InputGetter.MoveInput.x > 0) { entity.SpriteManager.SpriteRenderer.flipX = false; }
            else if (entity.InputGetter.MoveInput.x < 0) { entity.SpriteManager.SpriteRenderer.flipX = true; }
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