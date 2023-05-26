using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRoadSpawner : LoboMonoBehaviour
{
    [SerializeField] protected GameObject roadPrefab;

    [SerializeField] protected GameObject playerCtrl;
    protected override void Awake()
    {
        base.Awake();
    }
    protected override void LoadComponents()
    {
        this.LoadRoadPrefab();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadRoadPrefab()
    {
        if (this.roadPrefab != null) return;
        this.roadPrefab = GameObject.Find("RoadPrefab");
        Debug.Log(transform.name + ": LoadRoadPrefab", gameObject);
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GameObject.Find("PlayerCtrl");
        Debug.Log(transform.name + ": LoadPlayerCtrl", gameObject);
    }
}
