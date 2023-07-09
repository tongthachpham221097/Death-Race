using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableMainMenu();
        this.OnEnableGarageMenu();
    }
}
