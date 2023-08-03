using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsButton : ItemBarPageBtn
{
    protected override void OnClick()
    {
        this.userInfoAvatar.WeaponsList.ItemBarOnClick(this.index);
    }

}
