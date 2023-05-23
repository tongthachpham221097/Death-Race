using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{
    [Header("Enemy")]
    [SerializeField] protected Despawner despawner;
    public Despawner Despawner { get => despawner; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDespawner();
    }
    protected virtual void LoadDespawner()
    {
        if (this.despawner != null) return;
        this.despawner = FindAnyObjectByType<Despawner>();
        Debug.Log(transform.name + ": LoadPlayerCtrl", gameObject);
    }
    protected override void ResetValue()
    {
        this.hp = 3;
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        if(this.IsDead())
        {
            EffectManager.instance.SpawnVFX("Explosion_A", transform.position, transform.rotation);
            this.despawner.Despawn();
        }
    }
}
