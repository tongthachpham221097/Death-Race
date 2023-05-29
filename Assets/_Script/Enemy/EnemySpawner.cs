using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    //[Header("Enemy")]
    
    protected override void ResetValue()
    {
        this.prefabName = "EnemyPrefab";
    }
    protected override void Update()
    {
        base.Update();
        this.CheckDead();
    }
    protected override GameObject Spawn(Vector3 pos)
    {
        pos.y -= 15;
        return base.Spawn(pos);
    }
}
