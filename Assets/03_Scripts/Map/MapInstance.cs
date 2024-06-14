using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInstance : MonoBehaviour
{
    [SerializeField]
    private Map mapData;

    [SerializeField]
    private BattleField field;

    public Map MapData => mapData;

    public BattleField Field => field;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
