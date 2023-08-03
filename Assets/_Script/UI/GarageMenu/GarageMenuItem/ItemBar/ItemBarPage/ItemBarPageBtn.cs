using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBarPageBtn : BaseButton
{
    [Header("Item Bar Page Btn")]
    [SerializeField] protected UserInfoAvatar userInfoAvatar;
    [SerializeField] protected int index;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUserInfoAvatar();
    }

    void LoadUserInfoAvatar()
    {
        if (this.userInfoAvatar != null) return;
        this.userInfoAvatar = FindAnyObjectByType<UserInfoAvatar>();
        Debug.Log(transform.name + ": LoadUserInfoAvatar", gameObject);
    }

    protected override void OnClick()
    {

    }
}
