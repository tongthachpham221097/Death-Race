using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : LoboMonoBehaviour
{
    [Header("DamageSender")]
    public int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.ColliderSendDamage(collision);
    }
    protected virtual void ColliderSendDamage(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        if (damageReceiver == null) return;
        // hàm GetComponent t?o s? lk gi?a hai obj, gi?a hai Script
        damageReceiver.Receive(this.damage);
    }
}
