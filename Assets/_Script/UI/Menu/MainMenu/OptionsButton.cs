using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableMainMenu();
        this.OnEnableOptionMenu();
    }
}
