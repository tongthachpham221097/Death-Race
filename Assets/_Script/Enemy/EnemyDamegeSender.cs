using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamegeSender : DamageSender
{
    //[Header("Enemy")]
    //public EnemyCtrl enemyCtrl;

    //private void Awake()
    //{
    //    // tạo liên kết trong realtime
    //    enemyCtrl = GetComponent<EnemyCtrl>();
    //}
    [SerializeField] protected EnemyDamageReceiver enemyDamageReceiver;
    public EnemyDamageReceiver EnemyDamageReceiver { get => enemyDamageReceiver; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyDamageReceiver();
    }
    protected virtual void LoadEnemyDamageReceiver()
    {
        if (this.enemyDamageReceiver != null) return;
        this.enemyDamageReceiver = FindAnyObjectByType<EnemyDamageReceiver>();
        Debug.Log(transform.name + ": LoadEnemyDamageReceiver", gameObject);
    }
    protected override void ColliderSendDamage(Collider2D collision)
    {
        
        base.ColliderSendDamage(collision);

        this.enemyDamageReceiver.Receive(1);
    }
}
