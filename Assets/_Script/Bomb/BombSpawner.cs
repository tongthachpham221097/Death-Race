using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider { get => playerCollider; }

    private void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObj = 17;
        this.LoadPlayerCollider();
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
    protected override void Update()
    {
        if (InputManager.Instance.pressKeySpace == 0) return;
        this.Spawn();
        //this.CheckDead();
    }
}
