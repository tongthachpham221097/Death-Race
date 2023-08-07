using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfo : LoboMonoBehaviour
{
    
    [SerializeField] private UserInfoAvatar _userInfoAvatar;
    public UserInfoAvatar UserInfoAvatar => _userInfoAvatar;

    [SerializeField] private StaticBar _staticBar;
    public StaticBar StaticBar => _staticBar;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUserInfoAvatar();
        this.LoadStaticBar();
    }

    void LoadUserInfoAvatar()
    {
        if (this._userInfoAvatar != null) return;
        this._userInfoAvatar = GetComponentInChildren<UserInfoAvatar>();
        Debug.Log(transform.name + ": LoadUserInfoAvatar", gameObject);
    }

    void LoadStaticBar()
    {
        if (this._staticBar != null) return;
        this._staticBar = GetComponentInChildren<StaticBar>();
        Debug.Log(transform.name + ": LoadStaticBar", gameObject);
    }

}
