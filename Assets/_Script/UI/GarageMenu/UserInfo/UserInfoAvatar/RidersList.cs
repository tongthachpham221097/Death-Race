using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidersList : BaseUserInfoAvatar
{
    [SerializeField] public List<Transform> Riders;

    protected override void PublicListTransform()
    {
        this.Riders = this.listTransform;
    }

    protected override void SaveIndex(int index)
    {
        this.userInfoStartRaceBtn.SaveIndexRider(index);
    }
}
