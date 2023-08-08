using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiresButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        base.OnClick();
        this.userInfo.UserInfoAvatar.TiresList.ItemBarOnClick(this.index);
        this.userInfo.StaticBar.DurabilitySlider.IncreaseCurrentPercent(this.index);
    }

    protected override void SaveIndexBg()
    {
        ItemBarPage itemBarPage = this.GetItemBarPage();
        itemBarPage.TiresPage.SaveCurrentIndexBg(this.indexBg);
    }

}
