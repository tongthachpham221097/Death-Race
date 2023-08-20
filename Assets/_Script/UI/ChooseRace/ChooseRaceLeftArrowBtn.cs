using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRaceLeftArrowBtn : BaseButton
{
    
    protected override void OnClick()
    {
        ManagersCtrl.Instance.UI.GetChooseRaceList().ClickLeftArrow();
    }

}
