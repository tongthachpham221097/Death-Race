using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffRiders : GarageMenuItemBtn
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 0;
    }
}
