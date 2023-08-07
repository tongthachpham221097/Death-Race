using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsWeapons : BaseListTransform
{
    
    [SerializeField] public List<Transform> PlayerAvatarsWeaponsList;

    protected override void PublicListTransform()
    {
        this.PlayerAvatarsWeaponsList = this.listTransform;
    }

}
