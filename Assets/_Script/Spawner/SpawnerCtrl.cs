using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : LoboMonoBehaviour
{
    private static SpawnerCtrl _instance;
    public static SpawnerCtrl Instance => _instance; 

    [SerializeField] private RoadSpawner _roadSpawner;
    public RoadSpawner RoadSpawner => _roadSpawner;

    [SerializeField] private CopSpawner _copSpawner;
    public CopSpawner CopSpawner => _copSpawner;

    [SerializeField] private ObstacleSpawner _obstacleSpawner;
    public ObstacleSpawner ObstacleSpawner => _obstacleSpawner;

    protected override void Awake()
    {
        if (SpawnerCtrl._instance != null) Debug.LogError("only 1 SpawnerCtrl allow to exist");
        SpawnerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRoadSpawner();
        this.LoadCopSpawner();
        this.LoadObstacleSpawner();
    }

    protected virtual void LoadRoadSpawner()
    {
        if (this._roadSpawner != null) return;
        this._roadSpawner = GetComponentInChildren<RoadSpawner>();
        Debug.Log(transform.name + ": LoadRoadSpawner", gameObject);
    }

    protected virtual void LoadCopSpawner()
    {
        if (this._copSpawner != null) return;
        this._copSpawner = GetComponentInChildren<CopSpawner>();
        Debug.Log(transform.name + ": LoadCopSpawner", gameObject);
    }

    protected virtual void LoadObstacleSpawner()
    {
        if (this._obstacleSpawner != null) return;
        this._obstacleSpawner = GetComponentInChildren<ObstacleSpawner>();
        Debug.Log(transform.name + ": LoadObstacleSpawner", gameObject);
    }

}
