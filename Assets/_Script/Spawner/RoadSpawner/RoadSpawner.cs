using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadSpawner : Spawner
{
    public List<Transform> Prefabs => prefabs;
    [SerializeField] private float _offset;
    private void Start()
    {
        this._offset = MainCamera.Instance.CameraSize * 2;
    }

    public void RoadSpawning(Vector3 pos)
    {
        int level = ManagersCtrl.Instance.LevelsManager.Level;
        Transform prefab = this.prefabs[level];
        Quaternion rot = Quaternion.identity;
        pos.y += this._offset;
        Transform obj = this.Spawn(prefab, pos, rot);
    }
}
