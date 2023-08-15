using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowButton : BaseArrowButton
{
    protected override void OnClick()
    {
        base.OnClick();
        ItemBarPage itemBarPage = this.GetItemBarPage();
        itemBarPage.ClickLeftArrowButton();
    }
}
