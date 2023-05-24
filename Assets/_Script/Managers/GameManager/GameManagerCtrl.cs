using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCtrl : LoboMonoBehaviour
{
    [Header("Game Manager Ctrl")]
    [SerializeField] protected DistanceText distanceText;
    public DistanceText DistanceText => distanceText;

    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider => playerCollider;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDistanceText();
        this.LoadPlayerCollider();
    }
    protected virtual void LoadDistanceText()
    {
        if (this.distanceText != null) return;
        this.distanceText = FindAnyObjectByType<DistanceText>();
        Debug.Log(transform.name + ": LoadDistanceText", gameObject);
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
}
