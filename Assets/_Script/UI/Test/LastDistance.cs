using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastDistance : BaseText
{
    
    protected override void Start()
    {
        this.EnableLastDistance();
    }
    public virtual void EnableLastDistance()
    {
        text.text = PlayerPrefs.GetInt("lastDistance").ToString();
    }

}
