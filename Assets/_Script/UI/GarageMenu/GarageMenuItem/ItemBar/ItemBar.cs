using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBar : LoboMonoBehaviour
{
    
    [SerializeField] private ItemBarPage _itemBarPage;
    public ItemBarPage ItemBarPage => _itemBarPage;

    [SerializeField] private ItemBg _itemBg;
    public ItemBg ItemBg => _itemBg;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemBarPage();
        this.LoadItemBg();
    }

    void LoadItemBarPage()
    {
        if (this._itemBarPage != null) return;
        this._itemBarPage = GetComponentInChildren<ItemBarPage>();
        Debug.Log(transform.name + ": LoadItemBarPage", gameObject);
    }

    void LoadItemBg()
    {
        if (this._itemBg != null) return;
        this._itemBg = GetComponentInChildren<ItemBg>();
        Debug.Log(transform.name + ": LoadItemBg", gameObject);
    }

}
