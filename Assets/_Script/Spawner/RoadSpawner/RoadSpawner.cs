using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadSpawner : Spawner
{
    [Header("Road Spawner")]
    [SerializeField] private float _offset;
    [SerializeField] private Vector3 _currentRoad;
    [SerializeField] private int _prefab;
    private void Start()
    {
        this._offset = MainCamera.Instance.CameraSize * 2;
        this._currentRoad = transform.position;
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    void UpdateRoad()
    {
        float PlayerPosY = this.GetPlayerPosY();
        if (PlayerPosY - this._currentRoad.y < this._offset / 2) return;
        this.RoadSpawning(this._currentRoad);
    }

    float GetPlayerPosY()
    {
        return ManagersCtrl.Instance.Player.GetPlayerPositionY();
    }

    public void RoadSpawning(Vector3 pos)
    {
        Transform prefab = this.prefabs[this._prefab];
        Quaternion rot = Quaternion.identity;
        pos.y += this._offset;
        Transform obj = this.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
        this._currentRoad = obj.position;
    }

    public void SetPrefab(int prefab)
    {
        this._prefab = prefab;
    }    

}
