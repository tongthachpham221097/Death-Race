using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBg : LoboMonoBehaviour
{
    
    [SerializeField] private ItemBgOn _itemBgOn;
    public ItemBgOn ItemBgOn => _itemBgOn;

    [SerializeField] private ItemBgOff _itemBgOff;
    public ItemBgOff ItemBgOff => _itemBgOff;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemBgOn();
        this.LoadItemBgOff();
    }

    void LoadItemBgOn()
    {
        if (this._itemBgOn != null) return;
        this._itemBgOn = GetComponentInChildren<ItemBgOn>();
        Debug.Log(transform.name + ": LoadItemBgOn", gameObject);
    }

    void LoadItemBgOff()
    {
        if (this._itemBgOff != null) return;
        this._itemBgOff = GetComponentInChildren<ItemBgOff>();
        Debug.Log(transform.name + ": LoadItemBgOff", gameObject);
    }

    public void BackgroundOnClick(int indexBg)
    {
        this._itemBgOn.DisableSomeGameObject(indexBg);
        this._itemBgOff.OnEnableSomeGameObject(indexBg);
        this._itemBgOff.DisableGameObject(indexBg);
        this._itemBgOn.OnEnableGameObject(indexBg);
    }

}
