using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RidersButton : ItemBarPageBtn
{

    protected override void OnClick()
    {
        this.userInfoAvatar.RidersList.ItemBarOnClick(this.index);
    }

}
