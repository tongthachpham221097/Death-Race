using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamegeSender : DamageSender
{
    [Header("Enemy")]
    public EnemyCtrl enemyCtrl;

    private void Awake()
    {
        // tạo liên kết trong realtime
        enemyCtrl = GetComponent<EnemyCtrl>();
    }

    protected override void ColliderSendDamage(Collider2D collision)
    {
        
        base.ColliderSendDamage(collision);

        this.enemyCtrl.damageReceiver.Receive(1);
    }
}
