using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseArrowButton : BaseButton
{

    [SerializeField] protected ItemBarPage itemBarPage;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemBarPage();
    }

    protected virtual void LoadItemBarPage()
    {
        if (this.itemBarPage != null) return;
        this.itemBarPage = transform.parent.parent.GetComponentInChildren<ItemBarPage>();
        Debug.Log(transform.name + ": LoadItemBarPage", gameObject);
    }

    protected override void OnClick()
    {
        
    }
}
