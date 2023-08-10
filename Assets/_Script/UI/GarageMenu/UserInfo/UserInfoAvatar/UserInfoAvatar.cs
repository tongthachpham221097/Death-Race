using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfoAvatar : LoboMonoBehaviour
{
    
    [SerializeField] private MotoBodysList _motoBodysList;
    public MotoBodysList MotoBodysList => _motoBodysList;

    [SerializeField] private RidersList _ridersList;
    public RidersList RidersList => _ridersList;

    [SerializeField] private TiresList _tiresList;
    public TiresList TiresList => _tiresList;

    [SerializeField] private WeaponsList _weaponsList;
    public WeaponsList WeaponsList => _weaponsList;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadMotoBodysList();
        this.LoadRidersList();
        this.LoadTiresList();
        this.LoadWeaponsList();
    }

    void LoadMotoBodysList()
    {
        if (this._motoBodysList != null) return;
        this._motoBodysList = GetComponentInChildren<MotoBodysList>();
        Debug.Log(transform.name + ": LoadMotoBodysList", gameObject);
    }

    void LoadRidersList()
    {
        if (this._ridersList != null) return;
        this._ridersList = GetComponentInChildren<RidersList>();
        Debug.Log(transform.name + ": LoadRidersList", gameObject);
    }

    void LoadTiresList()
    {
        if (this._tiresList != null) return;
        this._tiresList = GetComponentInChildren<TiresList>();
        Debug.Log(transform.name + ": LoadTiresList", gameObject);
    }

    void LoadWeaponsList()
    {
        if (this._weaponsList != null) return;
        this._weaponsList = GetComponentInChildren<WeaponsList>();
        Debug.Log(transform.name + ": LoadWeaponsList", gameObject);
    }

}
