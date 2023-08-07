using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBarPageBtn : BaseButton
{
    [Header("Item Bar Page Btn")]
    [SerializeField] protected UserInfo userInfo;
    [SerializeField] protected int index;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUserInfo();
    }

    void LoadUserInfo()
    {
        if (this.userInfo != null) return;
        this.userInfo = FindAnyObjectByType<UserInfo>();
        Debug.Log(transform.name + ": LoadUserInfo", gameObject);
    }

    protected override void OnClick(){}

}
