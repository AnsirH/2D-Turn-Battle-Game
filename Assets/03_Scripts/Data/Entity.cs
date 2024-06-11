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
    Sprite characterSprite;

    [SerializeField]
    AnimatorController animController;
}
