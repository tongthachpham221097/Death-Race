using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RidersButton : ItemBarPageBtn
{

    protected override void OnClick()
    {
        this.userInfo.UserInfoAvatar.RidersList.ItemBarOnClick(this.index);
        this.userInfo.StaticBar.HealthSlider.IncreaseCurrentPercent(this.index);
    }

}
