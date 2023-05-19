using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCtrl : LoboMonoBehaviour
{
    [SerializeField] protected LastDistance lastDistance;
    public LastDistance LastDistance { get => lastDistance; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadLastDistance();
    }
    protected virtual void LoadLastDistance()
    {
        if (this.lastDistance != null) return;
        this.lastDistance = FindAnyObjectByType<LastDistance>();
        Debug.Log(transform.name + ": LoadLastDistance", gameObject);
    }
}
