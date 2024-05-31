using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerJumpState : StateBase<PlayerController>
    {
        private float timer = 0.0f;
        public override void Enter(PlayerController entity)
        {
            timer = 0.0f;
            entity.CommandInvoker.Execute(Command.PlayerCommandInvoker.Commands.Jump);
            entity.SpriteManager.Anim.SetBool("IsJump", true);
        }

        public override void Exit(PlayerController entity)
        {
            entity.SpriteManager.Anim.SetBool("IsJump", false);
        }

        public override void Operation_FixedUpdate(PlayerController entity)
        {

        }

        public override void Operation_Update(PlayerController entity)
        {
            if (timer > 1.0f)
            {
                entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Fall);
                entity.InputGetter.DisableJump();
            }
            else
            {
                timer += Time.deltaTime;

                if (!entity.InputGetter.IsJump)
                {
                    entity.Movement.Rigid2D.velocity = new Vector2(entity.Movement.Rigid2D.velocity.x, entity.Movement.Rigid2D.velocity.y * 0.5f);
                    entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Fall);
                }
            }
        }
    }
}