using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButtonOn : BaseListTransform
{
    [SerializeField] public List<Transform> ItemButtonOnList;

    protected override void PublicListTransform()
    {
        this.ItemButtonOnList = this.listTransform;
    }

}
