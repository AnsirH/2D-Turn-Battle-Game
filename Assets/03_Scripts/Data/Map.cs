using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMap", menuName = "Create Data/Create New Map")]
public class Map : ScriptableObject
{
    [SerializeField]
    private string mapName;

    [SerializeField]
    private float encounterPercent;

    [SerializeField]
    private float distanceForEncounter;

    [SerializeField]
    private Entity[] enemies;

    [SerializeField]
    private int maxEnemyLevel;

    [SerializeField]
    private int minEnemyLevel;

    // 배틀 필드 배열 추가할 것.
    // 배틀 필드란 배틀을 하는 공간을 말하며, 배틀 카메라와 플레이어, 적의 위치를 포함한다.
}
