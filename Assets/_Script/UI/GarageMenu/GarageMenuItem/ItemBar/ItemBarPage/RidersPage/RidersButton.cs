using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RidersButton : ItemBarPageBtn
{
    
    protected override void OnClick()
    {
        base.OnClick();
        this.userInfo.UserInfoAvatar.RidersList.ItemBarOnClick(this.index);
        this.userInfo.StaticBar.HealthSlider.IncreaseCurrentPercent(this.index);
    }

    protected override void SaveIndexBg()
    {
        ItemBarPage itemBarPage = this.GetItemBarPage();
        itemBarPage.RidersPage.SaveCurrentIndexBg(this.indexBg);
    }

}
