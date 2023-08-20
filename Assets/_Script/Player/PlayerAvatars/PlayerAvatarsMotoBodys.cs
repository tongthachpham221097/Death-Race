using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsMotoBodys : BaseListTransform
{
    
    [SerializeField] public List<Transform> MotoBodysList;

    protected override void PublicListTransform()
    {
        this.MotoBodysList = this.listTransform;
    }

}
