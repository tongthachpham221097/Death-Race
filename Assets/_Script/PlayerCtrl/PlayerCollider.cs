using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : LoboMonoBehaviour
{
    [SerializeField] public int bombCount = 0;

    [SerializeField] protected PlayerCtrl playerCtrl;
    public PlayerCtrl PlayerCtrl { get => playerCtrl; }
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
        if (collision.gameObject.name == "ModelCar") this.ColliderWithCar();
        if (collision.gameObject.name == "ModelBomb") this.PickupBomb();
    }
    protected virtual void PickupBomb()
    {
        this.bombCount++;
    }
    protected virtual void ColliderWithCar()
    {
        Time.timeScale = 0;
        UIManager.instance.UICtrl.gameOverMenu.SetActive(true);
    }
   
}
