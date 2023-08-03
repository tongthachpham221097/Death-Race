using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePage : BaseListTransform
{

    [SerializeField] protected int indexPageOn = 0;

    public void ClickLeftArrowButton()
    {
        this.DecreaseIndexPageOn();
        this.DisableSomeGameObject(this.indexPageOn);
        this.OnEnableGameObject(this.indexPageOn);
    }

    void DecreaseIndexPageOn()
    {
        this.indexPageOn--;
        if (this.indexPageOn >= 0) return;
        this.indexPageOn = this.listTransform.Count - 1;
    }

    public void ClickRightArrowButton()
    {
        this.IncreaseIndexPageOn();
        this.DisableSomeGameObject(this.indexPageOn);
        this.OnEnableGameObject(this.indexPageOn);
    }

    void IncreaseIndexPageOn()
    {
        this.indexPageOn++;
        if (this.indexPageOn < this.listTransform.Count) return;
        this.indexPageOn = 0;
    }

    protected override void PublicListTransform(){}    

}
