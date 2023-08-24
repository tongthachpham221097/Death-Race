using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxSpawner : Spawner
{
    
    public void FxCollisionSpawning(Vector3 spawnPosition)
    {
        Transform prefab = this.prefabs[0];
        this.Spawning(prefab, spawnPosition);
    }

    public void FxAttackSpawning(Vector3 spawnPosition)
    {
        Transform prefab = this.prefabs[1];
        this.Spawning(prefab, spawnPosition);
    }

    void Spawning(Transform prefab, Vector3 spawnPosition)
    {
        Transform obj = this.Spawn(prefab, spawnPosition, transform.rotation);
        obj.gameObject.SetActive(true);
    }

}
