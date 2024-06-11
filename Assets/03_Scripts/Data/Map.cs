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

    // ��Ʋ �ʵ� �迭 �߰��� ��.
    // ��Ʋ �ʵ�� ��Ʋ�� �ϴ� ������ ���ϸ�, ��Ʋ ī�޶�� �÷��̾�, ���� ��ġ�� �����Ѵ�.
}
