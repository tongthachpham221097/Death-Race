using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoBodysPage : BaseListTransform
{

    [SerializeField] public List<Transform> MotoBodysPages;

    protected override void PublicListTransform()
    {
        this.MotoBodysPages = this.listTransform;
    }

}
