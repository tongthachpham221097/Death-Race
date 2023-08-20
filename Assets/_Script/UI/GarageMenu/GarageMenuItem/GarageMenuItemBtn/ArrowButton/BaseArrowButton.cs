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

    UIManager GetUIManager()
    {
        return ManagersCtrl.Instance.UI;
    }

    ItemBgOff GetItemBgOff()
    {
        return this.GetUIManager().GetItemBgOff();
    }

    protected virtual ItemBarPage GetItemBarPage()
    {
        return this.GetUIManager().GetItemBarPage();
    }

}
