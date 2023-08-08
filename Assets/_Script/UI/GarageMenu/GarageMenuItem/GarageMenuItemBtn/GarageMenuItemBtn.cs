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
        this.SetActiveItemButton();
        this.SetActiveItemBarPage();
        this.LoadCurrentBg();
    }

    void SetActiveItemButton()
    {
        ItemButtonOn itemButtonOn = this.garageMenuItem.ItemButtonOn;
        ItemButtonOff itemButtonOff = this.garageMenuItem.ItemButtonOff;

        itemButtonOn.OnEnableGameObject(this.index);
        itemButtonOn.DisableSomeGameObject(this.index);
        itemButtonOff.OnEnableSomeGameObject(this.index);
    }    

    void SetActiveItemBarPage()
    {
        ItemBarPage itemBarPage = this.garageMenuItem.ItemBar.ItemBarPage;

        itemBarPage.DisableAllGameObject();
        itemBarPage.OnEnableGameObject(this.index);

        itemBarPage.SetIndexPageOn(this.index);
    }

    void LoadCurrentBg()
    {

    }

}
