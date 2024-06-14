using Singleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BattleSystem : Singleton<BattleSystem>
{
    // 현재 배틀 중인지 검사하는 임시 변수. 배틀 상태 모두 추가하면 삭제할 것.
    private bool tempIsBattle = false;
    private BattleSystemStateMachine stateMachine;

    // 배틀시스템 이벤트 버스
    private readonly IDictionary<BattleSystemStateMachine.BattleSystemStates, UnityEvent> events = new Dictionary<BattleSystemStateMachine.BattleSystemStates, UnityEvent>();

    public BattleUnit playerUnit;
    public BattleUnit enemyUnit;
    public BattleSystemStateMachine StateMachine => stateMachine;


    protected override void Awake()
    {
        base.Awake();
        stateMachine = new BattleSystemStateMachine(this);
    }

    public void Subscribe(BattleSystemStateMachine.BattleSystemStates eventState, UnityAction listener)
    {
        UnityEvent thisEvent;

        if (events.TryGetValue(eventState, out thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            events.Add(eventState, thisEvent);
        }
    }

    public void Unsubscribe(BattleSystemStateMachine.BattleSystemStates eventState, UnityAction listener)
    {
        UnityEvent thisEvent;

        if (events.TryGetValue(eventState, out thisEvent))
        {
            thisEvent.RemoveListener(listener);
        }
    }

    public void Publish(BattleSystemStateMachine.BattleSystemStates eventState)
    {
        UnityEvent thisEvent;

        if (events.TryGetValue(eventState, out thisEvent))
        {
            thisEvent.Invoke();
        }
    }

    public void StartBattle()
    {
        CameraManager.Instance.ChangeCam(CameraManager.CamType.Battle);
        tempIsBattle = true;
        // 상태머신 Setup 상태로 전환
        stateMachine.ChangeState(BattleSystemStateMachine.BattleSystemStates.Setup);

        GameManager.Instance.Player.InputGetter.PlayerInput.SwitchCurrentActionMap("UI");
    }

    public void EndBattle()
    {
        tempIsBattle = false;

        
        GameManager.Instance.Player.InputGetter.PlayerInput.SwitchCurrentActionMap("Player");
    }

    public void CheckEncounter()
    {
        float randomNum = Random.Range(0.0f, 100.0f);
        if (randomNum <= MapManager.Instance.CurrentMap.MapData.EncounterPercent)
        {
            StartBattle();
        }
    }

    public void Update()
    {
        stateMachine.Updated();
    }

    public void FixedUpdate()
    {
        stateMachine.FixedUpdated();
    }

    private void OnGUI()
    {
        if (!tempIsBattle && GUI.Button(new Rect(20, 40, 100, 20), "Start Battle"))
        {
            StartBattle();
            CameraManager.Instance.ChangeCam(CameraManager.CamType.Battle);
        }
        if (tempIsBattle && GUI.Button(new Rect(20, 110, 100, 20), "End Battle"))
        {
            EndBattle();
            CameraManager.Instance.ChangeCam(CameraManager.CamType.PlayerFollow);
        }
    }
}
