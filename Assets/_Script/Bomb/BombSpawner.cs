using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    protected override void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObj = 17;
    }
    protected override void Update()
    {
        if (InputManager.Instance.pressKeySpace == 0 || this.playerCollider.bombCount == 0) return;
        this.Spawn();
        //this.CheckDead();
    }
}
