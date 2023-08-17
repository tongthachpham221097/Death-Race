using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawner : SpawnerByTime
{

    protected override void ResetValue()
    {
        base.ResetValue();
        this.timeDelay = 0f;
        this.offset = 1.5f;
    }

    protected override Transform GetPrefab()
    {
        if (this.isStart()) return this.prefabs[0];
        return this.prefabs[1];
    }

    bool isStart()
    {
        Vector3 playPos = PlayerCtrl.Instance.transform.position;
        if (playPos == Vector3.zero) return true;
        return false;
    }

}
