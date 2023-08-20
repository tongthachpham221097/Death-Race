using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsRiders : BaseListTransform
{

    [SerializeField] public List<Transform> RidersList;

    protected override void PublicListTransform()
    {
        this.RidersList = this.listTransform;
    }
}
