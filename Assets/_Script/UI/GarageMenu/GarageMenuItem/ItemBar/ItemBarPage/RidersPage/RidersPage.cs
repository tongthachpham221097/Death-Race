using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidersPage : BasePage
{
    
    [SerializeField] public List<Transform> RidersPages;

    protected override void PublicListTransform()
    {
        this.RidersPages = this.listTransform;
    }

}
