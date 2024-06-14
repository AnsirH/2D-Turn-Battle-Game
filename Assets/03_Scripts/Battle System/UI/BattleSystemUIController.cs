using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleSystemUIController : MonoBehaviour
{
    [SerializeField]
    PlayerBattleHud playerHud;

    [SerializeField]
    BattleHud enemyHud;

    [SerializeField]
    GameObject actionButtons;

    [SerializeField]
    GameObject skillButtons;

    private TextMeshProUGUI[] skillButtonTexts;

    // Start is called before the first frame update
    void Start()
    {
        BattleSystem.Instance.Subscribe(BattleSystemStateMachine.BattleSystemStates.Setup, EnterBattleSet);
        BattleSystem.Instance.Subscribe(BattleSystemStateMachine.BattleSystemStates.ActionSelect, ActiveActionButtons);
        gameObject.SetActive(false);
        skillButtonTexts = new TextMeshProUGUI[4];
        for (int i = 0; i < 4; ++i)
        {
            skillButtonTexts[i] = skillButtons.transform.GetChild(i).GetComponent<TextMeshProUGUI>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnterBattleSet()
    {
        playerHud.SetupHudInfo(BattleSystem.Instance.playerUnit.Name, 5/* 임시값 */, BattleSystem.Instance.playerUnit.MaxHp);
        enemyHud.SetupHudInfo(BattleSystem.Instance.enemyUnit.Name, 3/* 임시값 */, BattleSystem.Instance.enemyUnit.MaxHp);
        gameObject.SetActive(true);
        actionButtons.SetActive(false);
    }

    void ActiveActionButtons()
    {
        actionButtons.SetActive(true);
    }

    public void SetActiveSkillButtons(bool active)
    {
        actionButtons.SetActive(!active);
        skillButtons.SetActive(active);
    }
}
