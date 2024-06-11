using Singleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private PlayerController player;

    public PlayerController Player => player;

    protected override void Awake()
    {
        base.Awake();
        player = FindObjectOfType<PlayerController>();
    }
}
