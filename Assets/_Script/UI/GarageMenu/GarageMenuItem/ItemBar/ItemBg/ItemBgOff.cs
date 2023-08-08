using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBgOff : BaseListTransform
{
    
    [SerializeField] public List<Transform> ItemBgOffList;

    protected override void PublicListTransform()
    {
        this.ItemBgOffList = this.listTransform;
    }

}
