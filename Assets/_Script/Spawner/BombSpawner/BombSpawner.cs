using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{

    void Update()
    {
        this.BombSpawning();    
    }
    
    void BombSpawning()
    {
        if (!InputManager.Instance.PressSpace) return;

        Vector3 pos = PlayerCtrl.Instance.transform.position;
        Quaternion rot = transform.rotation;
        Transform prefab = this.RandomPrefab();
        Transform obj = this.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }

}
