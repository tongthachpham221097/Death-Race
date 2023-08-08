using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        base.OnClick();
        this.userInfo.UserInfoAvatar.WeaponsList.ItemBarOnClick(this.index);
        this.userInfo.StaticBar.DamageSlider.IncreaseCurrentPercent(this.index);
    }

    protected override void SaveIndexBg()
    {
        ItemBarPage itemBarPage = this.GetItemBarPage();
        itemBarPage.weaponsPage.SaveCurrentIndexBg(this.indexBg);
    }

}
