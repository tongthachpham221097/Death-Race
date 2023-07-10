using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadSpawner : Spawner
{
    public void RoadSpawning(Vector3 pos)
    {
        int level = ManagersCtrl.Instance.LevelsManager.Level;
        Transform prefab = this.prefabs[level];
        Quaternion rot = Quaternion.identity;
        pos += new Vector3(0, 27, 0);
        Transform obj = this.Spawn(prefab, pos, rot);
    }
}
