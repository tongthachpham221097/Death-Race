using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOff : BaseListTransform
{
    [SerializeField] public List<Transform> ItemButtonOffList;

    protected override void PublicListTransform()
    {
        this.ItemButtonOffList = this.listTransform;
    }

}
