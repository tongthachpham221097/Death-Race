using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRaceMenu : LoboMonoBehaviour
{

    [SerializeField] private ChooseRaceList _chooseRaceList;
    public ChooseRaceList ChooseRaceList => _chooseRaceList;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadChooseRaceList();
    }

    void LoadChooseRaceList()
    {
        if (this._chooseRaceList != null) return;
        this._chooseRaceList = GetComponentInChildren<ChooseRaceList>();
        Debug.Log(transform.name + ": LoadChooseRaceList", gameObject);
    }

}
