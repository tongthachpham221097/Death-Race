using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRaceLeftArrowBtn : BaseButton
{
    
    protected override void OnClick()
    {
        UICtrl.Instance.ChooseRaceMenu.ChooseRaceList.ClickLeftArrow();
    }

}
