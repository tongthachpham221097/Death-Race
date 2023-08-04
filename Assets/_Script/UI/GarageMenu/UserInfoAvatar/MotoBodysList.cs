using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoBodysList : BaseUserInfoAvatar
{
    [SerializeField] public List<Transform> MotoBodys;

    protected override void PublicListTransform()
    {
        this.MotoBodys = this.listTransform;
    }

    protected override void SaveIndex(int index)
    {
        this.userInfoStartRaceBtn.SaveIndexMotobody(index);
    }

}
