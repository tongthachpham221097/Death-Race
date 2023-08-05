using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsMotoBodys : BaseListTransform
{
    
    [SerializeField] public List<Transform> PlayerAvatarsMotoBodysList;

    protected override void PublicListTransform()
    {
        this.PlayerAvatarsMotoBodysList = this.listTransform;
    }

}
