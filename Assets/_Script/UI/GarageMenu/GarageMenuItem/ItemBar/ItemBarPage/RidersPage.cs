using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidersPage : BaseListTransform
{
    
    [SerializeField] public List<Transform> RidersPages;

    protected override void PublicListTransform()
    {
        this.RidersPages = this.listTransform;
    }

}
