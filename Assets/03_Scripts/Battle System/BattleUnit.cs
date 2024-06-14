using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnit : MonoBehaviour
{
    public Entity UnitEntity { get; private set; }
    public string Name { get; private set; }
    public int MaxHp { get; private set; }
    public int CurrentHp { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Speed { get; private set; }

    public Animator anim;
    public SpriteRenderer spriteRenderer;

    public void DataSetup(Entity entity)
    {
        UnitEntity = entity;
        Name = entity.EntityName;
        MaxHp = entity.Hp;
        CurrentHp = entity.Hp;
        Attack = entity.Attack;
        Defense = entity.Defense;
        Speed = entity.Speed;
        spriteRenderer.sprite = entity.CharacterSprite;
        anim.runtimeAnimatorController = entity.AnimController;
    }
}
