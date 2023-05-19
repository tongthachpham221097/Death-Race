using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : LoboMonoBehaviour
{
    //Header("Enemy Ctrl")]
    //public Despawner despawner;
    //public EnemyDamageReceiver damageReceiver;
    [SerializeField] protected PlayerCtrl playerCtrl;
    public PlayerCtrl PlayerCtrl { get => playerCtrl; }

    //public Transform PlayerCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = FindAnyObjectByType<PlayerCtrl>();
        Debug.Log(transform.name + ": LoadPlayerCtrl", gameObject);
    }
    //private void Awake()
    //{
    //    this.despawner = GetComponent<Despawner>();

    //    this.damageReceiver = GetComponent<EnemyDamageReceiver>();
    //}
}
