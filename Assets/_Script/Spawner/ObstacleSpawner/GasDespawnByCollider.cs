using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasDespawnByCollider : ObstacleDespawnByCollider
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        SpawnerCtrl.Instance.Fx.FxCollisionSpawning(transform.parent.position);
    }
}
