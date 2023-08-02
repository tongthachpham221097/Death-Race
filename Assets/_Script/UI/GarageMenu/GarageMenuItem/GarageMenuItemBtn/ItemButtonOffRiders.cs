using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffRiders : GarageMenuItemBtn
{
    protected override void OnClick()
    {
        base.OnClick();
        this.garageMenuItem.ItemButtonOn.OnEnableGameObject(0);
        
    }
}
