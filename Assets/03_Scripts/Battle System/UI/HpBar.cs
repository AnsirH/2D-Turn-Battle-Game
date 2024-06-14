using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField]
    private RectTransform hpBarImage;

    public void SetHpBar(int currentHp, int maxHp)
    {
        hpBarImage.localScale = new Vector3((float)currentHp / maxHp, 1, 1);
    }
}
