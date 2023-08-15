using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDespawner : LoboMonoBehaviour
{
    
    protected virtual void Despawning()
    {
        SpawnerCtrl.Instance.ObstacleSpawner.Despawn(transform.parent);
    }

}
