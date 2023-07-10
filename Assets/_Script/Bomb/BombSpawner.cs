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


    }

}
