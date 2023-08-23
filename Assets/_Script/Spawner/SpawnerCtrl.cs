using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : LoboMonoBehaviour
{
    private static SpawnerCtrl _instance;
    public static SpawnerCtrl Instance => _instance; 

    [SerializeField] private RoadSpawner _roadSpawner;
    public RoadSpawner Road => _roadSpawner;

    [SerializeField] private CopSpawner _copSpawner;
    public CopSpawner Cop => _copSpawner;

    [SerializeField] private ObstacleSpawner _obstacleSpawner;
    public ObstacleSpawner Obstacle => _obstacleSpawner;

    [SerializeField] private FxSpawner _fxSpawner;
    public FxSpawner Fx => _fxSpawner;

    protected override void Awake()
    {
        if (SpawnerCtrl._instance != null) Debug.LogError("only 1 SpawnerCtrl allow to exist");
        SpawnerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRoad();
        this.LoadCop();
        this.LoadObstacle();
        this.LoadFx();
    }

    protected virtual void LoadRoad()
    {
        if (this._roadSpawner != null) return;
        this._roadSpawner = GetComponentInChildren<RoadSpawner>();
        Debug.Log(transform.name + ": LoadRoadSpawner", gameObject);
    }

    protected virtual void LoadCop()
    {
        if (this._copSpawner != null) return;
        this._copSpawner = GetComponentInChildren<CopSpawner>();
        Debug.Log(transform.name + ": LoadCopSpawner", gameObject);
    }

    protected virtual void LoadObstacle()
    {
        if (this._obstacleSpawner != null) return;
        this._obstacleSpawner = GetComponentInChildren<ObstacleSpawner>();
        Debug.Log(transform.name + ": LoadObstacleSpawner", gameObject);
    }

    protected virtual void LoadFx()
    {
        if (this._fxSpawner != null) return;
        this._fxSpawner = GetComponentInChildren<FxSpawner>();
        Debug.Log(transform.name + ": LoadFx", gameObject);
    }

}
