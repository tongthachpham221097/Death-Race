using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRaceMenu : BaseListTransform
{
    
    [SerializeField] public List<Transform> races;
    
    protected override void PublicListTransform()
    {
        this.races = this.listTransform;
    }

}
