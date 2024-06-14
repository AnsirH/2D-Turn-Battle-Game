using State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleSystemStateMachine
{
    public enum BattleSystemStates { Setup = 0, ActionSelect }

    private BattleSystem battleSystem;
    private StateBase<BattleSystem>[] states;
    private StateBase<BattleSystem> currentState;

    public BattleSystemStateMachine(BattleSystem battleSystem)
    {
        this.battleSystem = battleSystem;
        states = new StateBase<BattleSystem>[2];
        states[(int)BattleSystemStates.Setup] = new BattleSystemSetupState();
        states[(int)BattleSystemStates.ActionSelect] = new BattleSystemActionSelectState();
    }

    public void Updated()
    {
        currentState?.Operation_Update(battleSystem);
    }

    public void FixedUpdated()
    {
        currentState?.Operation_FixedUpdate(battleSystem);
    }

    public void ChangeState(BattleSystemStates newState)
    {
        if (currentState != null)
        {
            currentState.Exit(battleSystem);
        }
        currentState = states[(int)newState];
        currentState.Enter(battleSystem);
    }
}
