using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopSpawnerBike : LoboMonoBehaviour
{
    [SerializeField] private BikeList _bikeList;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBikeList();
    }

    void LoadBikeList()
    {
        if (this._bikeList != null) return;
        this._bikeList = GetComponentInChildren<BikeList>();
        Debug.Log(transform.name + ": LoadBikeList", gameObject);
    }

    private void OnEnable()
    {
        this._bikeList.OnEnableRamdomBike();
    }
}
