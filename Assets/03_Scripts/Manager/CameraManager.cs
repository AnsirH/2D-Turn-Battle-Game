using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using Cinemachine;

public class CameraManager : Singleton<CameraManager>
{
    [SerializeField]
    private CinemachineVirtualCamera playerFollowCam;
    [SerializeField]
    private CinemachineVirtualCamera battleCam;

    public enum CamType
    {
        PlayerFollow,
        Battle
    }

    public void ChangeCam(CamType type)
    {
        switch (type)
        {
            case CamType.PlayerFollow:
                playerFollowCam.Priority = 10;
                battleCam.Priority = 0;
                break;
            case CamType.Battle:
                playerFollowCam.Priority = 0;
                battleCam.Priority = 10;
                break;
        }
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 40, 100, 20), "PlayerFollow Cam"))
        {
            ChangeCam(CamType.PlayerFollow);
        }

        if (GUI.Button(new Rect(20, 70, 100, 20), "Battle Cam"))
        {
            ChangeCam(CamType.Battle);
        }
    }
}