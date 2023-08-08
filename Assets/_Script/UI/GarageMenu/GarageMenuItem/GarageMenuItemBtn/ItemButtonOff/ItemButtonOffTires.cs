using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffTires : GarageMenuItemBtn
{

    protected override int LoadCurrentBg()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBarPage.TiresPage.CurrentBg;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 3;
    }
}
