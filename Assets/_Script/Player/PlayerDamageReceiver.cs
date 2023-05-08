using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{
    protected PlayerCtrl playerCtrl;
    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void Receive(int damage)
    {
        // override cần phải gọi lại hàm cũ
        base.Receive(damage);// gọi đến hàm Receive bên DamageReceiver
        if (this.IsDead())
        {
            this.playerCtrl.playerStatus.Dead();
            UIManager.instance.bnGameOver.SetActive(true);
        }
    }

}
