using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBgOn : BaseListTransform
{
    
    [SerializeField] public List<Transform> ItemBgOnList;

    protected override void PublicListTransform()
    {
        this.ItemBgOnList = this.listTransform;
    }

}
