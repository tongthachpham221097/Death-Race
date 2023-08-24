using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : SpawnByTime
{

    protected override void ResetValue()
    {
        base.ResetValue();
        this.timeDelay = 10f;
        this.offset = 20f;
    }

    protected override float RamdomSpawnPosition()
    {
        return Random.Range(-3,3);
    }

}
