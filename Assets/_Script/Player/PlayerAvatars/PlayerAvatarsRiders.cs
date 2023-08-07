using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsRiders : BaseListTransform
{

    [SerializeField] public List<Transform> PlayerAvatarsRidersList;

    protected override void PublicListTransform()
    {
        this.PlayerAvatarsRidersList = this.listTransform;
    }
}
