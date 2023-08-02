using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidersList : BaseListTransform
{
    [SerializeField] public List<Transform> Riders;

    protected override void PublicListTransform()
    {
        this.Riders = this.listTransform;
    }

}
