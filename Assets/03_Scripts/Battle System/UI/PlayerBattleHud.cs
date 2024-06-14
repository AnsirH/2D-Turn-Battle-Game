using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBattleHud : BattleHud
{
    [SerializeField]
    private TextMeshProUGUI hpText;

    public override void SetupHudInfo(string name, int level, int maxHp)
    {
        base.SetupHudInfo(name, level, maxHp);
        SetHpText(maxHp, maxHp);
    }

    public void SetHpText(int currentHp, int maxHp)
    {
        hpText.text = currentHp + "/" + maxHp;
    }
}
