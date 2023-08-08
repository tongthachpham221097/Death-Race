using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoBodysButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        base.OnClick();
        this.userInfo.UserInfoAvatar.MotoBodysList.ItemBarOnClick(this.index);
        this.userInfo.StaticBar.SpeedSlider.IncreaseCurrentPercent(this.index);
    }

    protected override void SaveIndexBg()
    {
        ItemBarPage itemBarPage = this.GetItemBarPage();
        itemBarPage.MotoBodysPage.SaveCurrentIndexBg(this.indexBg);
        itemBarPage.MotoBodysPage.SaveCurrentIndexPage(this.GetIndexPage());
    }

}
