using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCheckPoint : LoboMonoBehaviour
{
    
    void Update()
    {
        this.CheckPoint();
    }

    void CheckPoint()
    {
        if (transform.position.y - PlayerCtrl.Instance.transform.position.y > 0) return;
        SpawnerCtrl.Instance.RoadSpawner.RoadSpawning(transform.position);
    }

}
