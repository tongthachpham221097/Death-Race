using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiresButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        this.userInfoAvatar.TiresList.ItemBarOnClick(this.index);
    }

}
