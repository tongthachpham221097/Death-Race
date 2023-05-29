using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider { get => playerCollider; }
    protected override void ResetValue()
    {
        this.prefabName = "BombPrefab";
        this.maxObj = 99;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCollider();
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
    protected override void Update()
    {
        if (InputManager.Instance.pressKeySpace == 0) return;
        if (this.playerCollider.bombCount == 0) return;
        this.Spawn();
    }
    protected override GameObject Spawn(Vector3 pos)
    {
        this.playerCollider.bombCount--;
        return base.Spawn(pos); ;
    }
}
