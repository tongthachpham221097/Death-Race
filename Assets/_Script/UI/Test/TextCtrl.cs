using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCtrl : LoboMonoBehaviour
{
    [Header("Text Ctrl")]
    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider { get => playerCollider; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCollider();
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
}
