using Singleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : Singleton<MapManager>
{
    public MapInstance forestMap;

    public MapInstance CurrentMap { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        CurrentMap = forestMap;
    }
}
