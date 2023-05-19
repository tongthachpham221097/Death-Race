using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombCountText : TestManager
{
    [SerializeField] protected Text bombCountText;
    protected override void Reset()
    {
        base.Reset();
        this.bombCountText = GetComponent<Text>();
    }
    protected virtual void FixedUpdate()
    {
        this.GetBombCount();
    }
    protected virtual void GetBombCount()
    {
        bombCountText.text = "BombCount: " + this.playerCollider.bombCount.ToString();  
    }
}
