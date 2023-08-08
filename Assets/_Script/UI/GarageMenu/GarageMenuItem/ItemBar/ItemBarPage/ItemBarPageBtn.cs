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
        itemBg.ItemBgOn.DisableSomeGameObject(this.indexBg);
        itemBg.ItemBgOff.OnEnableSomeGameObject(this.indexBg);
        itemBg.ItemBgOff.DisableGameObject(this.indexBg);
        itemBg.ItemBgOn.OnEnableGameObject(this.indexBg);
        this.SaveIndexBg();
    }

    protected virtual ItemBarPage GetItemBarPage()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBarPage;
    }

    void CalIndexBg()
    {
        if (this.index == 0 || this.index == 3 || this.index == 6) this.indexBg = 0;
        else if (this.index == 1 || this.index == 4 || this.index == 7) this.indexBg = 1;
        else this.indexBg = 2;
    }

    ItemBg GetItemBg()
    {
        return UICtrl.Instance.GarageMenu.GarageMenuItem.ItemBar.ItemBg;
    }

    void GetUserInfo()
    {
        this.userInfo = UICtrl.Instance.GarageMenu.UserInfo;
    }

    protected abstract void SaveIndexBg();

}
