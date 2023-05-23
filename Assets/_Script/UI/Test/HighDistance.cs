using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighDistance : BaseText
{    
    protected override void Start()
    {
        this.EnableHighDistance();
    }
    public virtual void EnableHighDistance()
    {
        text.text = PlayerPrefs.GetInt("highDistance").ToString();
    }
}
