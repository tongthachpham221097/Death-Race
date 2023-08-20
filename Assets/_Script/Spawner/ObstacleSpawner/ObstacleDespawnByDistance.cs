using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDespawnByDistance : ObstacleDespawner
{

    [SerializeField] private float _distance = 10f;

    private void FixedUpdate()
    {
        this.DespawningByDistance();
    }

    void DespawningByDistance()
    {
        if (this.CheckDistance()) return;
        this.Despawning();
    }

    bool CheckDistance()
    {
        float playerPosY = this.GetPlayerPositionY();
        float prefabPosY = transform.parent.position.y;
        if (playerPosY - prefabPosY < this._distance) return true;
        return false;
    }

    float GetPlayerPositionY()
    {
        return ManagersCtrl.Instance.Player.GetPlayerPositionY();
    }

}
