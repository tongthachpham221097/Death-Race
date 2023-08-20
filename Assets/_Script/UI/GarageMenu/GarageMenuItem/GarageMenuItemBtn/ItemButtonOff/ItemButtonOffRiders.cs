using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffRiders : GarageMenuItemBtn
{

    protected override int LoadCurrentBg()
    {
        return ManagersCtrl.Instance.UI.GetItemBarPage().RidersPage.CurrentBg;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 0;
    }

}
