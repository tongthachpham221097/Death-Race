using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRaceButton : BaseButton
{
    protected override void OnClick()
    {
        this.DisableMainMenu();
    }

}
