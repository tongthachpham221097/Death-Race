using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOffTires : GarageMenuItemBtn
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.index = 3;
    }
}
