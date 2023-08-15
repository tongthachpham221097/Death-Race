using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopSpawner : Spawner
{
    [Header("Cop Spawner")]
    [SerializeField] private float _timer;
    [SerializeField] private float _timeDelay = 5f;

    private void FixedUpdate()
    {
        this.CopSpawning();
    }

    void CopSpawning()
    {
        if (this.TimeDelay()) return;
        
        Transform prefab = this.RandomPrefab();
        Vector3 copPosition = this.GetCopPosition();
        Transform obj = this.Spawn(prefab, copPosition, Quaternion.identity);
        obj.gameObject.SetActive(true);
    }

    bool TimeDelay()
    {
        this._timer += Time.fixedDeltaTime;
        if(this._timer < this._timeDelay) return true;
        this._timer = 0;
        return false;
    }

    Vector3 GetCopPosition()
    {
        Vector3 playerPosition = this.GetPlayerPosition();

        Vector3 copPosition = playerPosition;
        copPosition.y = playerPosition.y - MainCamera.Instance.CameraSize * 2;
        return copPosition;
    }

    Vector3 GetPlayerPosition()
    {
        return PlayerCtrl.Instance.transform.position;
    }
    
}
