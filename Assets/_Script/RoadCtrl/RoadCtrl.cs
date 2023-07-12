using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCtrl : LoboMonoBehaviour
{
    private static RoadCtrl _instance;
    public static RoadCtrl Instance { get => _instance; }

    [SerializeField] private int _level = 0;
    public int Level => _level;

    [SerializeField] private List<Transform> _roads;
    public List<Transform> Roads => _roads;

    [SerializeField] private List<RoadSpawner> _roadSpawners;
    public List<RoadSpawner> RoadSpawners => _roadSpawners;

    protected override void Awake()
    {
        base.Awake();
        if (RoadCtrl._instance != null) Debug.LogError("only 1 RoadCtrl allow to exist");
        RoadCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRoads();
        this.AppearRoad();
        this.LoadRoadSpawners();
    }

    void LoadRoads()
    {
        if (this._roads.Count > 0) return;

        foreach (Transform road in transform)
        {
            this._roads.Add(road);
            road.gameObject.SetActive(false);
        }

        Debug.LogWarning(transform.name + ": LoadRoads", gameObject);
    }

    void LoadRoadSpawners()
    {
        if (this._roadSpawners.Count > 0) return;

        foreach (Transform road in transform)
        {
            this._roadSpawners.Add(road.GetComponent<RoadSpawner>());
        }

        Debug.LogWarning(transform.name + ": LoadRoadSpawners", gameObject);
    }

    void AppearRoad()
    {
        this._roads[this._level].gameObject.SetActive(true);
    }    
}
