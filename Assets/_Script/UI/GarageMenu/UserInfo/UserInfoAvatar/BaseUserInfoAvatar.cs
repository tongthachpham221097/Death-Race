using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUserInfoAvatar : BaseListTransform
{
    
    protected override void PublicListTransform() { }

    protected abstract void SaveIndex(int index);

    public void ItemBarOnClick(int index)
    {
        this.DisableSomeGameObject(index);
        this.OnEnableGameObject(index);
        this.SaveIndex(index);
    }

    protected virtual UserInfoStartRaceBtn GetUserInfoStartRaceBtn()
    {
        return UICtrl.Instance.GarageMenu.UserInfo.UserInfoStartRaceBtn;
    }

}
