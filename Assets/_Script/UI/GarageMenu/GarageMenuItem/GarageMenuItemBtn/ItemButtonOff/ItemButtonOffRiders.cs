using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffRiders : GarageMenuItemBtn
{

    protected override int LoadCurrentBg()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBarPage.RidersPage.CurrentBg;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 0;
    }

}
