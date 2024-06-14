using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEntity", menuName = "Create Data/Create New Entity")]
public class Entity : ScriptableObject
{
    [SerializeField]
    private string entityName;

    [SerializeField]
    private int hp;

    [SerializeField]
    private int attack;

    [SerializeField]
    private int defense;

    [SerializeField]
    private int speed;

    [SerializeField]
    private Sprite characterSprite;

    [SerializeField]
    private AnimatorController animController;

    public string EntityName => entityName;
    public int Hp => hp;
    public int Attack => attack;
    public int Defense => defense;
    public int Speed => speed;
    public Sprite CharacterSprite => characterSprite;
    public AnimatorController AnimController => animController;
}
