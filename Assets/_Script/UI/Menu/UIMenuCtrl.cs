using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuCtrl : LoboMonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    public GameObject PauseMenu => _pauseMenu;

    [SerializeField] private GameObject _gameOverMenu;
    public GameObject GameOverMenu => _gameOverMenu;

    [SerializeField] private GameObject _mainMenu;
    public GameObject MainMenu => _mainMenu;

    [SerializeField] private GameObject _optitonsMenu;
    public GameObject OptitonsMenu => _optitonsMenu;

    [SerializeField] private GameObject _garageMenu;
    public GameObject GarageMenu => _garageMenu;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPauseMenu();
        this.LoadGameOverMenu();
        this.LoadMainMenu();
        this.LoadOptitonsMenu();
        this.LoadGarageMenu();
    }

    protected virtual void LoadGameOverMenu()
    {
        if (this._gameOverMenu != null) return;
        this._gameOverMenu = GameObject.Find("GameOverMenu");
        Debug.LogWarning(transform.name + ": LoadGameOverMenu", gameObject);
    }
    protected virtual void LoadPauseMenu()
    {
        if (this._pauseMenu != null) return;
        this._pauseMenu = GameObject.Find("PauseMenu");
        Debug.LogWarning(transform.name + ": LoadPauseMenu", gameObject);
    }

    protected virtual void LoadMainMenu()
    {
        if (this._mainMenu != null) return;
        this._mainMenu = GameObject.Find("MainMenu");
        Debug.LogWarning(transform.name + ": LoadMainMenu", gameObject);
    }

    protected virtual void LoadOptitonsMenu()
    {
        if (this._optitonsMenu != null) return;
        this._optitonsMenu = GameObject.Find("OptitonsMenu");
        Debug.LogWarning(transform.name + ": LoadOptitonsMenu", gameObject);
    }

    protected virtual void LoadGarageMenu()
    {
        if (this._garageMenu != null) return;
        this._garageMenu = GameObject.Find("GarageMenu");
        Debug.LogWarning(transform.name + ": LoadGarageMenu", gameObject);
    }
}
