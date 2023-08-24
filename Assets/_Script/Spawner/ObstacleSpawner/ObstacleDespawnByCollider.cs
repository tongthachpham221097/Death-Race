using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDespawnByCollider : ObstacleDespawner
{
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        this.Despawning();
    }

}
