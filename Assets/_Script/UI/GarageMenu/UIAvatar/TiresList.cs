using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiresList : BaseListTransform
{
    [SerializeField] public List<Transform> Tires;

    protected override void PublicListTransform()
    {
        this.Tires = this.listTransform;
    }

}
