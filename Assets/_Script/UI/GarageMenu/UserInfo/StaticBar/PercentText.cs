using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercentText : BaseText
{
    public void SetPercentText(float currentPercent)
    {
        this.text.text = currentPercent.ToString() + "%";
    }
}
