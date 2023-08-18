using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGoRaceBtn : BaseButton
{

    protected int indexPrefabRace;

    protected override void OnClick()
    {
        SpawnerCtrl.Instance.RoadSpawner.SetPrefab(this.indexPrefabRace);
        ManagersCtrl.Instance.UIManager.DisableChooseRaceMenu();
    }

}
