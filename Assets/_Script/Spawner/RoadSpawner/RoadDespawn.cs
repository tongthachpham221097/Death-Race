using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDespawn : LoboMonoBehaviour
{
    [SerializeField] private float _distance;

    

    void RoadDespawning()
    {
        float playerPosY = PlayerCtrl.Instance.transform.position.y;
        if (playerPosY - transform.parent.position.y < this._distance) return;

        SpawnerCtrl.Instance.RoadSpawner.Despawn(transform.parent);
        SpawnerCtrl.Instance.RoadSpawner.RoadSpawning(transform.parent.position);
    }

}
