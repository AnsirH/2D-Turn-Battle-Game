using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSkill", menuName = "Create Data/Create New Skill")]
public class Skill : ScriptableObject
{
    [SerializeField]
    private string skillName;

    [SerializeField]
    private int power;

    [SerializeField]
    private int speed;
}
