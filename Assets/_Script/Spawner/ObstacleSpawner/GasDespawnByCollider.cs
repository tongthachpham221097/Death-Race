using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasDespawnByCollider : ObstacleDespawnByCollider
{
    protected override void Action()
    {
        SpawnerCtrl.Instance.Fx.FxCollisionSpawning(transform.parent.position);
    }
}
