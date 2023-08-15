using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBtn : BaseButton
{
    protected override void OnClick()
    {
        this.DisableGarageMenu();
        this.OnEnableMainMenu();
    }
}
