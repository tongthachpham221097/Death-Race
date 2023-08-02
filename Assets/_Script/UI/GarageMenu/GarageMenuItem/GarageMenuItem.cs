using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageMenuItem : LoboMonoBehaviour
{
    [SerializeField] private ItemButtonOff _itemButtonOff;
    public ItemButtonOff ItemButtonOff => _itemButtonOff;

    [SerializeField] private ItemButtonOn _itemButtonOn;
    public ItemButtonOn ItemButtonOn => _itemButtonOn;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemButtonOff();
        this.LoadItemButtonOn();
    }

    void LoadItemButtonOff()
    {
        if (this._itemButtonOff != null) return;
        this._itemButtonOff = GetComponentInChildren<ItemButtonOff>();
        Debug.Log(transform.name + ": LoadItemButtonOff", gameObject);
    }

    void LoadItemButtonOn()
    {
        if (this._itemButtonOn != null) return;
        this._itemButtonOn = GetComponentInChildren<ItemButtonOn>();
        Debug.Log(transform.name + ": LoadItemButtonOn", gameObject);
    }

}
