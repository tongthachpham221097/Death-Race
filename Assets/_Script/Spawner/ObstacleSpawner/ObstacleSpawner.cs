using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : SpawnerByTime
{

    protected override void ResetValue()
    {
        base.ResetValue();
        this.timeDelay = 5f;
        this.offset = 20;
    }

    protected override float RamdomSpawnPosition()
    {
        float spawnPositionX = Random.Range(-3.1f, 3.1f);
        return spawnPositionX;
    }

}
