using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CopSpawnerList : BaseListTransform
{
    [Header("CopSpawner List")]
    [SerializeField] protected int ramdom;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.DisableAllGameObject();
    }

    protected virtual void OnEnable()
    {
        this.OnEnableRamdomObject();
    }

    protected virtual void OnEnableRamdomObject()
    {
        this.ramdom = Random.Range(0, this.listTransform.Count);
        this.OnEnableGameObject(this.ramdom);
    }

    protected override void PublicListTransform(){}

}
