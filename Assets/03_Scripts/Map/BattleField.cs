using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleField : MonoBehaviour
{
    [SerializeField]
    private Transform playerPosition;

    [SerializeField]
    private Transform enemyPosition;

    public Vector3 PlayerPosition => playerPosition.position;
    public Vector3 EnemyPosition => enemyPosition.position;
}
