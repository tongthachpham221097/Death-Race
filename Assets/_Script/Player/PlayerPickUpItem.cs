using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpItem : LoboMonoBehaviour
{
    [SerializeField] public int bombCount = 0;

    [SerializeField] protected PlayerCtrl playerCtrl;
    public PlayerCtrl PlayerCtrl { get => playerCtrl; }

    [SerializeField] public bool isGameOver = false;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GetComponentInParent<PlayerCtrl>();
        Debug.Log(transform.name + ": LoadPlayerCtrl", gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ModelCar") this.isGameOver = true;
        if (collision.gameObject.name == "ModelBomb") this.bombCount++;
    }
}
