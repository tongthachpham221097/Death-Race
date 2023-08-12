using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : LoboMonoBehaviour
{
    private static SpawnerCtrl _instance;
    public static SpawnerCtrl Instance => _instance; 

    [SerializeField] private RoadSpawner _roadSpawner;
    public RoadSpawner RoadSpawner => _roadSpawner; 

    protected override void Awake()
    {
        if (SpawnerCtrl._instance != null) Debug.LogError("only 1 SpawnerCtrl allow to exist");
        SpawnerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRoadSpawner();
    }

    protected virtual void LoadRoadSpawner()
    {
        if (this._roadSpawner != null) return;
        this._roadSpawner = GetComponentInChildren<RoadSpawner>();
        Debug.Log(transform.name + ": LoadRoadSpawner", gameObject);
    }

}
