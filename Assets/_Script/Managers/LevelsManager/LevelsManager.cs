using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : LoboMonoBehaviour
{
    [SerializeField] private int _level = 0;
    public int Level => _level;

    private void Start()
    {
        this.AppearRoad();
    }

    void AppearRoad()
    {
        SpawnerCtrl.Instance.RoadSpawner.Prefabs[this._level].gameObject.SetActive(true);
    }    
}
