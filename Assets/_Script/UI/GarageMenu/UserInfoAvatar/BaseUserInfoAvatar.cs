using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUserInfoAvatar : BaseListTransform
{

    public void ItemBarOnClick(int index)
    {
        this.DisableSomeGameObject(index);
        this.OnEnableGameObject(index);
    }

    protected override void PublicListTransform() { }

}
