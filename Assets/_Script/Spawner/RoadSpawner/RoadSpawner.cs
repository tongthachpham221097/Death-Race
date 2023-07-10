using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadSpawner : Spawner
{
    public void RoadSpawning()
    {
        int level = 0;
        Transform prefab = this.prefabs[level];
        Vector3 pos = PlayerCtrl.Instance.transform.position;
        Quaternion rot = Quaternion.identity;
        Transform obj = this.Spawn(prefab, pos, rot);
    }
}
