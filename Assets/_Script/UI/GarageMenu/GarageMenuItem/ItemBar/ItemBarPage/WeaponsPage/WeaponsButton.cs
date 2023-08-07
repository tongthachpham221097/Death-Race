using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        this.userInfo.UserInfoAvatar.WeaponsList.ItemBarOnClick(this.index);
        this.userInfo.StaticBar.DamageSlider.IncreaseCurrentPercent(this.index);
    }

}
