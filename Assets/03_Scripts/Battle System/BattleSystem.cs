using Singleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : Singleton<BattleSystem>
{
    private bool tempIsBattle = false;
    // 배틀시스템 상태머신

    public void StartBattle()
    {
        CameraManager.Instance.ChangeCam(CameraManager.CamType.Battle);
        tempIsBattle = true;
        // 상태머신 Battle Set 상태로 전환

        GameManager.Instance.Player.InputGetter.PlayerInput.SwitchCurrentActionMap("UI");
    }

    public void EndBattle()
    {
        tempIsBattle = false;

        GameManager.Instance.Player.InputGetter.PlayerInput.SwitchCurrentActionMap("Player");
    }

    public void CheckEncounter()
    {
        float randomNum = Random.Range(0.0f, 100.0f);
        if (randomNum <= 30.0f /* <- 맵 고유의 적 출현 확률 넣을 것 */)
        {
            StartBattle();
        }
    }

    private void OnGUI()
    {
        if (tempIsBattle && GUI.Button(new Rect(20, 110, 100, 20), "End Battle"))
        {
            EndBattle();
            CameraManager.Instance.ChangeCam(CameraManager.CamType.PlayerFollow);
        }
    }
}
