using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDespawn : LoboMonoBehaviour
{
    [SerializeField] private float _distance;

    private void Start()
    {
        this._distance = MainCamera.Instance.CameraSize * 4;
    }

    private void Update()
    {
        this.RoadDespawning();    
    }

    void RoadDespawning()
    {
        float playerPosY = this.GetPlayerPositionY();
        if (playerPosY - transform.parent.position.y < this._distance) return;

        SpawnerCtrl.Instance.Road.Despawn(transform.parent);
    }

    float GetPlayerPositionY()
    {
        return ManagersCtrl.Instance.Player.GetPlayerPositionY();
    }

}
