using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerAbstract : LoboMonoBehaviour
{
    [SerializeField] protected GameManagerCtrl gameManagerCtrl;
    public GameManagerCtrl GameManagerCtrl => gameManagerCtrl;

    protected AudioSource audioSource;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGameManagerCtrl();
    }
    protected virtual void LoadGameManagerCtrl()
    {
        if (this.gameManagerCtrl != null) return;
        this.gameManagerCtrl = FindAnyObjectByType<GameManagerCtrl>();
        Debug.Log(transform.name + ": LoadGameManagerCtrl", gameObject);
    }
}
