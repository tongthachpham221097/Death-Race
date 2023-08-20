using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsTires : BaseListTransform
{

    [SerializeField] public List<Transform> TiresList;

    protected override void PublicListTransform()
    {
        this.TiresList = this.listTransform;
    }

}
