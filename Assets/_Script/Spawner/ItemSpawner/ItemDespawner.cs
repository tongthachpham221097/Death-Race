using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawner : MonoBehaviour
{

    private void FixedUpdate()
    {
        this.Despawning();
    }

    void Despawning()
    {
        float playerPosY = ManagersCtrl.Instance.Player.GetPlayerPositionY();
        if (playerPosY - transform.parent.position.y < 20) return;
        SpawnerCtrl.Instance.Item.Despawn(transform.parent);
    }

}
