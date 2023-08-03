using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GarageMenuItemBtn : BaseButton
{
    [SerializeField] protected GarageMenuItem garageMenuItem;
    [SerializeField] protected int index;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGarageMenuItem();
    }

    void LoadGarageMenuItem()
    {
        if (this.garageMenuItem != null) return;
        this.garageMenuItem = GetComponentInParent<GarageMenuItem>();
        Debug.Log(transform.name + ": LoadGarageMenuItem", gameObject);
    }

    protected override void OnClick()
    {
        transform.gameObject.SetActive(false);
        this.ItemButton();

        this.garageMenuItem.ItemBar.ItemBarPage.DisableSomeGameObject(this.index);
        this.garageMenuItem.ItemBar.ItemBarPage.OnEnableGameObject(this.index);

    }

    void ItemButton()
    {
        this.garageMenuItem.ItemButtonOn.OnEnableGameObject(this.index);
        this.garageMenuItem.ItemButtonOn.DisableSomeGameObject(this.index);
        this.garageMenuItem.ItemButtonOff.OnEnableSomeGameObject(this.index);
    }    

}
