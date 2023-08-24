using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleDespawnByCollider : ObstacleDespawner
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        this.Despawning();
        this.Action();
    }

    protected abstract void Action();

}
