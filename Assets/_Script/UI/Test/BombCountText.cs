using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombCountText : BaseText
{
    protected virtual void FixedUpdate()
    {
        this.GetBombCount();
    }
    protected virtual void GetBombCount()
    {
        text.text = "BombCount: " + this.TextCtrl.PlayerCollider.bombCount.ToString();  
    }
}
