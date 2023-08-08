using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageMenu : LoboMonoBehaviour
{
    
    [SerializeField] private UserInfo _userInfo;
    public UserInfo UserInfo => _userInfo;

    [SerializeField] private GarageMenuItem _garageMenuItem;
    public GarageMenuItem GarageMenuItem => _garageMenuItem;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUserInfo();
        this.LoadGarageMenuItem();
    }

    void LoadUserInfo()
    {
        if (this._userInfo != null) return;
        this._userInfo = GetComponentInChildren<UserInfo>();
        Debug.Log(transform.name + ": LoadUserInfo", gameObject);
    }

    void LoadGarageMenuItem()
    {
        if (this._garageMenuItem != null) return;
        this._garageMenuItem = GetComponentInChildren<GarageMenuItem>();
        Debug.Log(transform.name + ": LoadGarageMenuItem", gameObject);
    }

}
