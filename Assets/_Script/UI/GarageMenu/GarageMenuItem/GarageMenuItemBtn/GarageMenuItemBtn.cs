using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GarageMenuItemBtn : BaseButton
{
    [SerializeField] protected GarageMenuItem garageMenuItem;
    [SerializeField] protected int index;

    protected override void Start()
    {
        base.Start();
        this.garageMenuItem = UICtrl.Instance.GarageMenu.GarageMenuItem;
    }

    protected override void OnClick()
    {
        transform.gameObject.SetActive(false);
        this.SetActiveItemButton();
        this.SetActiveItemBarPage();
        this.SetCurrentBg();
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

    protected virtual void SetCurrentBg()
    {
        ItemBg itemBg = this.GetItemBg();
        itemBg.BackgroundOnClick(this.LoadCurrentBg());
    }

    ItemBg GetItemBg()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBg;
    }

    protected abstract int LoadCurrentBg();

}
