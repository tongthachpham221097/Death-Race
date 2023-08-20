using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffWeapons : GarageMenuItemBtn
{

    protected override int LoadCurrentBg()
    {
        return ManagersCtrl.Instance.UI.GetItemBarPage().WeaponsPage.CurrentBg;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 2;
    }

}
