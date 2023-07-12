using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : LoboMonoBehaviour
{
    private static SpawnerCtrl _instance;
    public static SpawnerCtrl Instance { get => _instance; }

    [SerializeField] private BombSpawner _bombSpawner;
    public BombSpawner BombSpawner { get => _bombSpawner; }

    protected override void Awake()
    {
        if (SpawnerCtrl._instance != null) Debug.LogError("only 1 SpawnerCtrl allow to exist");
        SpawnerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBombSpawner();
    }

    protected virtual void LoadBombSpawner()
    {
        if (this._bombSpawner != null) return;
        this._bombSpawner = GetComponentInChildren<BombSpawner>();
        Debug.Log(transform.name + ": LoadBombSpawner", gameObject);
    }

}
