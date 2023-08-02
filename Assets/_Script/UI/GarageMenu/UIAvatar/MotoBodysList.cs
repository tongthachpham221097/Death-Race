using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoBodysList : BaseListTransform
{
    [SerializeField] public List<Transform> MotoBodys;

    protected override void PublicListTransform()
    {
        this.MotoBodys = this.listTransform;
    }

}
