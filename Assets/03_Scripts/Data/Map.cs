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

    public string MapName => mapName;
    public float EncounterPercent => encounterPercent;
    public float DistanceForEncounter => distanceForEncounter;
    public Entity[] Enemies => enemies;
    public int MaxEnemyLevel => maxEnemyLevel;
    public int MinEnemyLevel => minEnemyLevel;
}
