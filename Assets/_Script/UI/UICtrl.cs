using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{

    [SerializeField] private GarageMenu _garageMenu;
    public GarageMenu GarageMenu => _garageMenu;

    [SerializeField] private MainMenu _mainMenu;
    public MainMenu MainMenu => _mainMenu;

    [SerializeField] private ChooseRaceMenu _chooseRaceMenu;
    public ChooseRaceMenu ChooseRaceMenu => _chooseRaceMenu;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGarageMenu();
        this.LoadMainMenu();
        this.LoadChooseRaceMenu();
    }

    void LoadGarageMenu()
    {
        if (this._garageMenu != null) return;
        this._garageMenu = GetComponentInChildren<GarageMenu>();
        Debug.Log(transform.name + ": LoadGarageMenu", gameObject);
    }

    void LoadMainMenu()
    {
        if (this._mainMenu != null) return;
        this._mainMenu = GetComponentInChildren<MainMenu>();
        Debug.Log(transform.name + ": LoadMainMenu", gameObject);
    }

    void LoadChooseRaceMenu()
    {
        if (this._chooseRaceMenu != null) return;
        this._chooseRaceMenu = GetComponentInChildren<ChooseRaceMenu>();
        Debug.Log(transform.name + ": LoadChooseRaceMenu", gameObject);
    }

}
