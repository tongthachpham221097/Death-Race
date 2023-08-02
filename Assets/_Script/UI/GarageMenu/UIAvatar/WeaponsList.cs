using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsList : BaseListTransform
{
    [SerializeField] public List<Transform> Weapons;

    protected override void PublicListTransform()
    {
        this.Weapons = this.listTransform;
    }

}
