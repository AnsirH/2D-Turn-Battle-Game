using State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystemActionSelectState : StateBase<BattleSystem>
{
    public override void Enter(BattleSystem entity)
    {
        entity.Publish(BattleSystemStateMachine.BattleSystemStates.ActionSelect);
    }

    public override void Exit(BattleSystem entity)
    {
    }

    public override void Operation_FixedUpdate(BattleSystem entity)
    {
    }

    public override void Operation_Update(BattleSystem entity)
    {
    }
}
