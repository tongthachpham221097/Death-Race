using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBarPage : BaseListTransform
{
    [SerializeField] public List<Transform> ItemBarPages;

    protected override void PublicListTransform()
    {
        this.ItemBarPages = this.listTransform;
    }

}
