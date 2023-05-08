using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl instance;
    
    public DamageReceiver damageReceiver;
    public PlayerStatus playerStatus;
    private void Awake()
    {
        PlayerCtrl.instance = this;
        // sử dụng Singleton khi biết chắc class này chỉ tồn tại 1 lần trong code của project
        
        this.damageReceiver = GetComponent<DamageReceiver>();
        this.playerStatus = GetComponent<PlayerStatus>();

    }
}
