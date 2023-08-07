using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatarsTires : BaseListTransform
{

    [SerializeField] public List<Transform> PlayerAvatarsTiresList;

    protected override void PublicListTransform()
    {
        this.PlayerAvatarsTiresList = this.listTransform;
    }

}
