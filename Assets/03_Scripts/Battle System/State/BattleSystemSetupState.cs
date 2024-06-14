using State;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Animations;

public class BattleSystemSetupState : StateBase<BattleSystem>
{
    private float timer = 0.0f;
    public override void Enter(BattleSystem entity)
    {
        // �÷��̾� ���� ������ �¾�
        entity.playerUnit.DataSetup(GameManager.Instance.Player.PlayerEntity);

        // �� ���� ������ �¾�
        entity.enemyUnit.DataSetup(MapManager.Instance.CurrentMap.MapData.Enemies[0]);

        // ��Ʋ ���� ��ġ ����
        entity.playerUnit.transform.position = MapManager.Instance.CurrentMap.Field.PlayerPosition;
        entity.enemyUnit.transform.position = MapManager.Instance.CurrentMap.Field.EnemyPosition;

        entity.Publish(BattleSystemStateMachine.BattleSystemStates.Setup);
        timer = 0.0f;
    }

    public override void Exit(BattleSystem entity)
    {
    }

    public override void Operation_FixedUpdate(BattleSystem entity)
    {
    }

    public override void Operation_Update(BattleSystem entity)
    {
        if (timer >= 2.0f)
        {
            entity.StateMachine.ChangeState(BattleSystemStateMachine.BattleSystemStates.ActionSelect);
            timer = 0.0f;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
