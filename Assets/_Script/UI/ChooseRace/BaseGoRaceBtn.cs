using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGoRaceBtn : BaseButton
{

    [SerializeField] protected int indexPrefabRace;

    protected override void OnClick()
    {
        SpawnerCtrl.Instance.Road.SetPrefab(this.indexPrefabRace);
        ManagersCtrl.Instance.UI.DisableChooseRaceMenu();
    }

}
