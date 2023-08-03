using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowButton : BaseArrowButton
{
    protected override void OnClick()
    {
        this.itemBarPage.ClickLeftArrowButton();
    }
}
