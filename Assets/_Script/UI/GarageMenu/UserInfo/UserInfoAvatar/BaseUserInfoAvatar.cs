using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUserInfoAvatar : BaseListTransform
{

    [SerializeField] protected UserInfoStartRaceBtn userInfoStartRaceBtn;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUserInfoStartRaceBtn();
    }

    void LoadUserInfoStartRaceBtn()
    {
        if (this.userInfoStartRaceBtn != null) return;
        this.userInfoStartRaceBtn = FindAnyObjectByType<UserInfoStartRaceBtn>();
        Debug.Log(transform.name + ": LoadUserInfoStartRaceBtn", gameObject);
    }

    public void ItemBarOnClick(int index)
    {
        this.DisableSomeGameObject(index);
        this.OnEnableGameObject(index);
        this.SaveIndex(index);
    }

    protected abstract void SaveIndex(int index);

    protected override void PublicListTransform() { }

}
