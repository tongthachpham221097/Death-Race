using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffMotobodys : GarageMenuItemBtn
{

    protected override int LoadCurrentBg()
    {
        return ManagersCtrl.Instance.UI.GetItemBarPage().MotoBodysPage.CurrentBg;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 1;
    }

}
