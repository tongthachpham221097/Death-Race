using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopSpawner : SpawnByTime
{
    
    protected override void ResetValue()
    {
        base.ResetValue();
        this.timeDelay = 5f;
        this.offset = -20f;
    }

}
