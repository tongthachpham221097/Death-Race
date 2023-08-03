using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoBodysButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        this.userInfoAvatar.MotoBodysList.ItemBarOnClick(this.index);
    }
}
