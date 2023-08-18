using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnByTime : Spawner
{
    [SerializeField] protected float timer;
    [SerializeField] protected float timeDelay;
    [SerializeField] protected float offset;

    protected virtual void FixedUpdate()
    {
        this.Spawning();
    }

    protected virtual void Spawning()
    {
        if (this.TimeDelay()) return;

        Transform prefab = this.GetPrefab();
        Vector3 spawnPosition = this.GetSpawnPosition();
        Transform obj = this.Spawn(prefab, spawnPosition, Quaternion.identity);
        obj.gameObject.SetActive(true);
    }

    protected virtual Transform GetPrefab()
    {
        return this.RandomPrefab();
    }
    protected virtual bool TimeDelay()
    {
        this.timer += Time.fixedDeltaTime;
        if (this.timer < this.timeDelay) return true;
        this.timer = 0;
        return false;
    }

    protected virtual Vector3 GetSpawnPosition()
    {
        Vector3 spawnPosition = this.GetPlayerPosition();
        spawnPosition.y += this.offset;
        spawnPosition.x = this.RamdomSpawnPosition();
        return spawnPosition;
    }

    protected virtual float RamdomSpawnPosition()
    {
        return 0;
    }

    protected virtual Vector3 GetPlayerPosition()
    {
        return PlayerCtrl.Instance.transform.position;
    }

}
