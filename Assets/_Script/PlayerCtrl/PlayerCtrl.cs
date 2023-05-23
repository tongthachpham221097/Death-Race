using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : LoboMonoBehaviour
{
    //public DamageReceiver damageReceiver;
    //public PlayerStatus playerStatus;
    [SerializeField] protected UICtrl uiCtrl;
    public UICtrl UICtrl => uiCtrl;
    protected override void Awake()
    {
        //this.damageReceiver = GetComponent<DamageReceiver>();
        //this.playerStatus = GetComponent<PlayerStatus>();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUICtrl();
    }
    protected virtual void LoadUICtrl()
    {
        if (this.uiCtrl != null) return;
        this.uiCtrl = FindAnyObjectByType<UICtrl>();
        Debug.Log(transform.name + ": LoadUICtrl", gameObject);
    }
}
