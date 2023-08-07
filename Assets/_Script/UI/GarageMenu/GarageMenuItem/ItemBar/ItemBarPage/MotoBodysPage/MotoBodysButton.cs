using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoBodysButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        this.userInfo.UserInfoAvatar.MotoBodysList.ItemBarOnClick(this.index);
        this.userInfo.StaticBar.SpeedSlider.IncreaseCurrentPercent(this.index);
    }
}
