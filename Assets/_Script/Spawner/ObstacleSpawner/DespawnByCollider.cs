using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByCollider : ObstacleDespawner
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        this.Despawning();
        SpawnerCtrl.Instance.Fx.FxCollisionSpawning(transform.parent.position);
    }
}
