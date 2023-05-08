using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        CarSpawner.Instance.Despawn(transform.parent);
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 20f;
    }
}
