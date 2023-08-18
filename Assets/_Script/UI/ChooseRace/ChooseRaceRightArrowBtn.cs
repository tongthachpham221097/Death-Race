using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRaceRightArrowBtn : BaseButton
{
    protected override void OnClick()
    {
        UICtrl.Instance.ChooseRaceMenu.ChooseRaceList.ClickRightArrow();
    }
}
