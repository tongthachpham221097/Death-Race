using System.Collections;
using System.Collections.Generic;
//using Unity.Mathematics;
using UnityEngine;

public class CarSpawnerRandom : LoboMonoBehaviour
{
    [Header("Car Spawner Random")]
    [SerializeField] protected CarSpawnerCtrl carSpawnerCtrl;
    [SerializeField] protected float randomDelay = 1f;
    [SerializeField] protected float randomTimer = 0f;
    [SerializeField] protected int randomLimit = 20;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCarSpawnerCtrl();
    }
    protected virtual void LoadCarSpawnerCtrl()
    {
        if (this.carSpawnerCtrl != null) return;
        this.carSpawnerCtrl = GetComponent<CarSpawnerCtrl>();
        Debug.Log(transform.name + ": LoadCarSpawnerCtrl", gameObject);
    }
    protected override void Start()
    {
        base.Start();
        InvokeRepeating(nameof(this.ChangeRamdomDelay), 1f, 3f);
        InvokeRepeating(nameof(this.ChangeRamdomLimit), 1f, 15f);
    }

    protected virtual void FixedUpdate()
    {
        this.CarSpawning();
    }
    protected virtual void CarSpawning()
    {
        if (this.RandomReachLimit()) return;

        this.randomTimer += Time.fixedDeltaTime;
        if (this.randomTimer < this.randomDelay) return;
        this.randomTimer = 0;

        Transform ranPoint = this.carSpawnerCtrl.SpawnPoints.GetRandom();
        Vector3 pos = ranPoint.position;
        Quaternion rot = transform.rotation;

        Transform prefab = this.carSpawnerCtrl.CarSpawner.RandomPrefab();
        Transform obj = this.carSpawnerCtrl.CarSpawner.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }
    protected virtual bool RandomReachLimit()
    {
        int currentCar = this.carSpawnerCtrl.CarSpawner.SpawnedCount;
        return currentCar >= this.randomLimit;
    }
    protected virtual void ChangeRamdomDelay()
    {
        this.randomDelay -= 0.01f;
        if(this.randomDelay < 0) this.randomDelay = 0;
    }
    protected virtual void ChangeRamdomLimit()
    {
        this.randomLimit += 1;
    }
}
