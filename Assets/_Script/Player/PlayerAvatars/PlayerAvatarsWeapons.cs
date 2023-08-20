using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsWeapons : BaseListTransform
{
    
    [SerializeField] public List<Transform> WeaponsList;

    protected override void PublicListTransform()
    {
        this.WeaponsList = this.listTransform;
    }

}
