using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseArrowButton : BaseButton
{

    protected override void OnClick()
    {
        ItemBgOff itemBgOff = this.GetItemBgOff();
        itemBgOff.OnEnableAllGameObject();
    }

    ItemBgOff GetItemBgOff()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBg.ItemBgOff;
    }

    protected virtual ItemBarPage GetItemBarPage()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBarPage;
    }

}
