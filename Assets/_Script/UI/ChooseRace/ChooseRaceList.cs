using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRaceList : BaseListTransform
{
    
    [SerializeField] public List<Transform> races;
    [SerializeField] private int _index;
    public int Index => _index;
    
    protected override void PublicListTransform()
    {
        this.races = this.listTransform;
    }

    public void ClickLeftArrow()
    {
        this.DecreaseIndex();
        this.DisableSomeGameObject(this._index);
        this.OnEnableGameObject(this._index);
    }

    public void ClickRightArrow()
    {
        this.IncreaseIndex();
        this.DisableSomeGameObject(this._index);
        this.OnEnableGameObject(this._index);
    }

    void DecreaseIndex()
    {
        this._index--;
        if (this._index < 0) this._index = this.races.Count - 1;
    }

    void IncreaseIndex()
    {
        this._index++;
        if (this._index >= this.races.Count) this._index = 0;
    }

}
