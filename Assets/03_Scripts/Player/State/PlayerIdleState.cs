using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace State
{
    public class PlayerIdleState : StateBase<PlayerController>
    {
        public override void Enter(PlayerController entity)
        {
            entity.CommandInvoker.Execute(Command.PlayerCommandInvoker.Commands.MoveStop);
        }

        public override void Exit(PlayerController entity)
        {
            // idle animation false
        }

        public override void Operation_FixedUpdate(PlayerController entity)
        {
        }

        public override void Operation_Update(PlayerController entity)
        {
            if (entity.InputGetter.IsJump)
            {
                entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Jump);
            }
            if (entity.InputGetter.IsMove)
            {
                entity.StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Move);
            }
        }
    }
}