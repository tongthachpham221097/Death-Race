using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxDespawn : LoboMonoBehaviour
{

    private void FixedUpdate()
    {
        this.Despawning();
    }

    void Despawning()
    {
        float playerPositionY = ManagersCtrl.Instance.Player.GetPlayerPositionY();
        if (playerPositionY - transform.parent.position.y < 20) return;
        SpawnerCtrl.Instance.Fx.Despawn(transform.parent);
    }    

}
