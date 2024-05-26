using State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement movement;
    private PlayerStateMachine stateMachine;
    private PlayerInputGetter inputGetter;

    // 프로퍼티
    public PlayerMovement Movement => movement;
    public PlayerStateMachine StateMachine => stateMachine;
    public PlayerInputGetter InputGetter => inputGetter;

    void Start()
    {
        if (!TryGetComponent<PlayerMovement>(out movement))
        {
            movement = gameObject.AddComponent<PlayerMovement>();
        }

        if (!TryGetComponent<PlayerInputGetter>(out inputGetter))
        {
            inputGetter = gameObject.AddComponent<PlayerInputGetter>();
        }
        stateMachine = new PlayerStateMachine(this);

        stateMachine.ChangeState(PlayerStateMachine.PlayerStates.Idle);
    }

    void Update()
    {
        stateMachine.Updated();
        if (inputGetter.IsJump)
        {
            Debug.Log("점프 중");

        }
    }

    private void FixedUpdate()
    {
        stateMachine.FixedUpdated();
    }
}
