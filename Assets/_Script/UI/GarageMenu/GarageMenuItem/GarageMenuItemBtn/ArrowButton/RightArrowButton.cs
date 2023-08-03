using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowButton : BaseArrowButton
{
    protected override void OnClick()
    {
        this.itemBarPage.ClickRightArrowButton();
    }
}
