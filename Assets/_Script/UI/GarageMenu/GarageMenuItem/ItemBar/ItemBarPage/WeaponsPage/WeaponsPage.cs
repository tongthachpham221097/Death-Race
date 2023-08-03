using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsPage : BasePage
{

    [SerializeField] public List<Transform> WeaponsPages;

    protected override void PublicListTransform()
    {
        this.WeaponsPages = this.listTransform;
    }

}
