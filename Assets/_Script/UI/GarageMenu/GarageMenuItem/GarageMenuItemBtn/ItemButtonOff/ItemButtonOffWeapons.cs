using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffWeapons : GarageMenuItemBtn
{

    protected override int LoadCurrentBg()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBarPage.WeaponsPage.CurrentBg;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 2;
    }

}
