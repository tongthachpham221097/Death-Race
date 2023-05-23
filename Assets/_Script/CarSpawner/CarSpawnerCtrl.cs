using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerCtrl : LoboMonoBehaviour
{
    [SerializeField] protected CarSpawner carSpawner;
    public CarSpawner CarSpawner { get => carSpawner; }

    [SerializeField] protected SpawnPoints spawnPoints;
    public SpawnPoints SpawnPoints { get => spawnPoints; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCarSpawner();
        this.LoadSpawnPoints();
    }
    protected virtual void LoadCarSpawner()
    {
        if (this.carSpawner != null) return;
        this.carSpawner = GetComponent<CarSpawner>();
        Debug.Log(transform.name + ": LoadCarSpawner", gameObject);
    }
    protected virtual void LoadSpawnPoints()
    {
        if (this.spawnPoints != null) return;
        this.spawnPoints = Transform.FindAnyObjectByType<CarSpawnPoints>();
        Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
    }
}
