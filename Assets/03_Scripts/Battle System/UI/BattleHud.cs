using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleHud : MonoBehaviour
{
    [SerializeField]
    protected TextMeshProUGUI nameText;

    [SerializeField]
    protected TextMeshProUGUI levelText;

    [SerializeField]
    protected HpBar hpBar;

    public virtual void SetupHudInfo(string name, int level, int maxHp)
    {
        nameText.text = name;
        levelText.text = "Lv " + level;
        hpBar.SetHpBar(maxHp, maxHp);
    }
}
