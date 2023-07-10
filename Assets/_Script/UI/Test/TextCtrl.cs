using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCtrl : LoboMonoBehaviour
{
    [Header("Text Ctrl")]
    [SerializeField] protected PlayerPickUpItem playerCollider;
    public PlayerPickUpItem PlayerCollider { get => playerCollider; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCollider();
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerPickUpItem>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
}
