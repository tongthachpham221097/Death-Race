using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatars : LoboMonoBehaviour
{
    [SerializeField] private PlayerAvatarsRiders _riders;
    public PlayerAvatarsRiders Riders => _riders;

    [SerializeField] private PlayerAvatarsMotoBodys _motoBodys;
    public PlayerAvatarsMotoBodys MotoBodys => _motoBodys;

    [SerializeField] private PlayerAvatarsWeapons _weapons;
    public PlayerAvatarsWeapons Weapons => _weapons;

    [SerializeField] private PlayerAvatarsTires _tires;
    public PlayerAvatarsTires Tires => _tires;

    [SerializeField] private RiderAnimation _riderAnimation;
    public RiderAnimation RiderAnimation => _riderAnimation;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRiders();
        this.LoadMotoBodys();
        this.LoadWeapons();
        this.LoadTires();
        this.LoadRiderAnimation();
    }

    void LoadRiders()
    {
        if (this._riders != null) return;
        this._riders = GetComponentInChildren<PlayerAvatarsRiders>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsRiders", gameObject);
    }

    void LoadMotoBodys()
    {
        if (this._motoBodys != null) return;
        this._motoBodys = GetComponentInChildren<PlayerAvatarsMotoBodys>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsMotoBodys", gameObject);
    }

    void LoadWeapons()
    {
        if (this._weapons != null) return;
        this._weapons = GetComponentInChildren<PlayerAvatarsWeapons>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsWeapons", gameObject);
    }

    void LoadTires()
    {
        if (this._tires != null) return;
        this._tires = GetComponentInChildren<PlayerAvatarsTires>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsTires", gameObject);
    }

    void LoadRiderAnimation()
    {
        if (this._riderAnimation != null) return;
        this._riderAnimation = GetComponentInChildren<RiderAnimation>();
        Debug.LogWarning(transform.name + ": LoadRiderAnimation", gameObject);
    }

}
