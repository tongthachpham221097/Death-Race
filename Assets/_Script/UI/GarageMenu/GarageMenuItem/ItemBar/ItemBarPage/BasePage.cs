using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePage : BaseListTransform
{

    [SerializeField] protected int indexPageOn = 0;
    public int IndexPageOn => indexPageOn;

    [SerializeField] protected int currentIndexBg;
    public int CurrentBg => currentIndexBg;

    [SerializeField] protected int currentIndexPage;
    public int CurrentIndexPage => currentIndexPage;

    public void ClickLeftArrowButton()
    {
        this.DecreaseIndexPageOn();
        this.DisableSomeGameObject(this.indexPageOn);
        this.OnEnableGameObject(this.indexPageOn);
        this.ShowCurrentBg();
    }

    public void ClickRightArrowButton()
    {
        this.IncreaseIndexPageOn();
        this.DisableSomeGameObject(this.indexPageOn);
        this.OnEnableGameObject(this.indexPageOn);
        this.ShowCurrentBg();
    }

    void DecreaseIndexPageOn()
    {
        this.indexPageOn--;
        if (this.indexPageOn >= 0) return;
        this.indexPageOn = this.listTransform.Count - 1;
    }

    void IncreaseIndexPageOn()
    {
        this.indexPageOn++;
        if (this.indexPageOn < this.listTransform.Count) return;
        this.indexPageOn = 0;
    }

    void ShowCurrentBg()
    {
        if (this.indexPageOn != this.currentIndexPage) return;
        ItemBg itemBg = this.GetItemBg();
        itemBg.BackgroundOnClick(this.currentIndexBg);
    }

    ItemBg GetItemBg()
    {
        return ManagersCtrl.Instance.UI.GetItemBg();
    }
    
    public void SaveCurrentIndexBg(int index)
    {
        this.currentIndexBg = index;
    }

    public void SaveCurrentIndexPage(int index)
    {
        this.currentIndexPage = index;
    }

    protected override void PublicListTransform(){}    

}
