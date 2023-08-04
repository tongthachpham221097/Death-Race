using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiresPage : BasePage
{

    [SerializeField] public List<Transform> TiresPages;

    protected override void PublicListTransform()
    {
        this.TiresPages = this.listTransform;
    }

}
