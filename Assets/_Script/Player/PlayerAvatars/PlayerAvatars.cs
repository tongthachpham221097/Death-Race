using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatars : LoboMonoBehaviour
{
    [SerializeField] private PlayerAvatarsRiders _playerAvatarsRiders;
    public PlayerAvatarsRiders PlayerAvatarsRiders => _playerAvatarsRiders;

    [SerializeField] private PlayerAvatarsMotoBodys _playerAvatarsMotoBodys;
    public PlayerAvatarsMotoBodys PlayerAvatarsMotoBodys => _playerAvatarsMotoBodys;

    [SerializeField] private PlayerAvatarsWeapons _playerAvatarsWeapons;
    public PlayerAvatarsWeapons PlayerAvatarsWeapons => _playerAvatarsWeapons;

    [SerializeField] private PlayerAvatarsTires _playerAvatarsTires;
    public PlayerAvatarsTires PlayerAvatarsTires => _playerAvatarsTires;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerAvatarsRiders();
        this.LoadPlayerAvatarsMotoBodys();
        this.LoadPlayerAvatarsWeapons();
        this.LoadPlayerAvatarsTires();
    }

    void LoadPlayerAvatarsRiders()
    {
        if (this._playerAvatarsRiders != null) return;
        this._playerAvatarsRiders = GetComponentInChildren<PlayerAvatarsRiders>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsRiders", gameObject);
    }

    void LoadPlayerAvatarsMotoBodys()
    {
        if (this._playerAvatarsMotoBodys != null) return;
        this._playerAvatarsMotoBodys = GetComponentInChildren<PlayerAvatarsMotoBodys>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsMotoBodys", gameObject);
    }

    void LoadPlayerAvatarsWeapons()
    {
        if (this._playerAvatarsWeapons != null) return;
        this._playerAvatarsWeapons = GetComponentInChildren<PlayerAvatarsWeapons>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsWeapons", gameObject);
    }

    void LoadPlayerAvatarsTires()
    {
        if (this._playerAvatarsTires != null) return;
        this._playerAvatarsTires = GetComponentInChildren<PlayerAvatarsTires>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsTires", gameObject);
    }

}
