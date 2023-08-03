using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBarPage : BaseListTransform
{
    [SerializeField] public List<Transform> ItemBarPages;

    [SerializeField] private int _indexItemOn = 0;

    [SerializeField] private RidersPage _ridersPage;
    [SerializeField] private MotoBodysPage _motoBodysPage;
    [SerializeField] private TiresPage _tiresPage;
    [SerializeField] private WeaponsPage _weaponsPage;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRidersPage();
        this.LoadMotoBodysPage();
        this.LoadTiresPage();
        this.LoadWeaponsPage();
    }

    void LoadRidersPage()
    {
        if (this._ridersPage != null) return;
        this._ridersPage = GetComponentInChildren<RidersPage>();
        Debug.Log(transform.name + ": LoadRidersPage", gameObject);
    }

    void LoadMotoBodysPage()
    {
        if (this._motoBodysPage != null) return;
        this._motoBodysPage = GetComponentInChildren<MotoBodysPage>();
        Debug.Log(transform.name + ": LoadMotoBodysPage", gameObject);
    }

    void LoadTiresPage()
    {
        if (this._tiresPage != null) return;
        this._tiresPage = GetComponentInChildren<TiresPage>();
        Debug.Log(transform.name + ": LoadTiresPage", gameObject);
    }

    void LoadWeaponsPage()
    {
        if (this._weaponsPage != null) return;
        this._weaponsPage = GetComponentInChildren<WeaponsPage>();
        Debug.Log(transform.name + ": LoadWeaponsPage", gameObject);
    }

    protected override void PublicListTransform()
    {
        this.ItemBarPages = this.listTransform;
    }

    public void SetIndexPageOn(int indexPageOn)
    {
        this._indexItemOn = indexPageOn;
    }

    public void ClickLeftArrowButton()
    {

    }

}
