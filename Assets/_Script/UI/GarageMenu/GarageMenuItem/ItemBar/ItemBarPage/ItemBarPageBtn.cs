using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBarPageBtn : BaseButton
{
    [Header("Item Bar Page Btn")]
    [SerializeField] protected int index;
    [SerializeField] protected int indexBg;
    public int IndexBg => indexBg;

    [SerializeField] protected UserInfo userInfo;

    protected override void Start()
    {
        base.Start();
        this.GetUserInfo();
        this.CalIndexBg();
    }

    protected override void OnClick()
    {
        ItemBg itemBg = this.GetItemBg();
        itemBg.BackgroundOnClick(this.indexBg);

        this.SaveIndexBg();
    }

    protected virtual ItemBarPage GetItemBarPage()
    {
        return ManagersCtrl.Instance.UI.GetItemBarPage();
    }

    void CalIndexBg()
    {
        if (this.index == 0 || this.index == 3 || this.index == 6) this.indexBg = 0;
        else if (this.index == 1 || this.index == 4 || this.index == 7) this.indexBg = 1;
        else this.indexBg = 2;
    }

    ItemBg GetItemBg()
    {
        return ManagersCtrl.Instance.UI.GetItemBg();
    }

    void GetUserInfo()
    {
        this.userInfo = ManagersCtrl.Instance.UI.GetUserInfo();
    }

    protected virtual int GetIndexPage()
    {
        if (this.index == 0 || this.index == 1 || this.index == 2) return 0;
        else if(this.index == 3 || this.index == 4 || this.index == 5) return 1;
        else return 2;
    }

    protected abstract void SaveIndexBg();

}
