using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBar : LoboMonoBehaviour
{
    [SerializeField] private ItemBarPage _itemBarPage;
    public ItemBarPage ItemBarPage => _itemBarPage;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemBarPage();
    }

    void LoadItemBarPage()
    {
        if (this._itemBarPage != null) return;
        this._itemBarPage = GetComponentInChildren<ItemBarPage>();
        Debug.Log(transform.name + ": LoadItemBarPage", gameObject);
    }

}
