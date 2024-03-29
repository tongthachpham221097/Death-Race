using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBarPage : BaseListTransform
{
    [SerializeField] public List<Transform> ItemBarPages;

    [SerializeField] private int _indexItemOn = 0;

    [SerializeField] private RidersPage _ridersPage;
    public RidersPage RidersPage => _ridersPage;

    [SerializeField] private MotoBodysPage _motoBodysPage;
    public MotoBodysPage MotoBodysPage => _motoBodysPage;

    [SerializeField] private TiresPage _tiresPage;
    public TiresPage TiresPage => _tiresPage;

    [SerializeField] private WeaponsPage _weaponsPage;
    public WeaponsPage WeaponsPage => _weaponsPage;

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
        if (this._indexItemOn == 0) this._ridersPage.ClickLeftArrowButton();
        if (this._indexItemOn == 1) this._motoBodysPage.ClickLeftArrowButton();
        if (this._indexItemOn == 2) this._weaponsPage.ClickLeftArrowButton();
        if (this._indexItemOn == 3) this._tiresPage.ClickLeftArrowButton();
    }

    public void ClickRightArrowButton()
    {
        if (this._indexItemOn == 0) this._ridersPage.ClickRightArrowButton();
        if (this._indexItemOn == 1) this._motoBodysPage.ClickRightArrowButton();
        if (this._indexItemOn == 2) this._weaponsPage.ClickRightArrowButton();
        if (this._indexItemOn == 3) this._tiresPage.ClickRightArrowButton();
    }

}
