using Command;
using State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(PlayerMovement),typeof(PlayerInputGetter))]
public class PlayerController : MonoBehaviour
{
    //private PlayerMovement movement;
    //private PlayerStateMachine stateMachine;
    //private PlayerInputGetter inputGetter;
    //private PlayerSpriteManager spriteManager;
    //// 프로퍼티
    //public PlayerMovement Movement => movement;
    //public PlayerStateMachine StateMachine => stateMachine;
    //public PlayerInputGetter InputGetter => inputGetter;
    //public PlayerSpriteManager SpriteManager => spriteManager;

    public PlayerMovement Movement { get; private set; }
    public PlayerInputGetter InputGetter { get; private set; }
    public PlayerSpriteManager SpriteManager { get; private set; }

    public PlayerStateMachine StateMachine { get; private set; }
    public PlayerCommandInvoker CommandInvoker{ get; private set; }

    void Start()
    {
        Movement = GetComponent<PlayerMovement>();
        InputGetter = GetComponent<PlayerInputGetter>();
        SpriteManager = GetComponentInChildren<PlayerSpriteManager>();

        StateMachine = new PlayerStateMachine(this);
        CommandInvoker = new PlayerCommandInvoker(this);

        StateMachine.ChangeState(PlayerStateMachine.PlayerStates.Idle);
    }

    void Update()
    {
        StateMachine.Updated();
    }

    private void FixedUpdate()
    {
        StateMachine.FixedUpdated();
    }
}
