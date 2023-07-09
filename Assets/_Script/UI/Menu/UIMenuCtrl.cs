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

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPauseMenu();
        this.LoadGameOverMenu();
        this.LoadMainMenu();
    }

    protected virtual void LoadGameOverMenu()
    {
        if (this._gameOverMenu != null) return;
        this._gameOverMenu = GameObject.Find("GameOverMenu");
        Debug.Log(transform.name + ": LoadGameOverMenu", gameObject);
    }
    protected virtual void LoadPauseMenu()
    {
        if (this._pauseMenu != null) return;
        this._pauseMenu = GameObject.Find("PauseMenu");
        Debug.Log(transform.name + ": LoadPauseMenu", gameObject);
    }

    protected virtual void LoadMainMenu()
    {
        if (this._mainMenu != null) return;
        this._mainMenu = GameObject.Find("MainMenu");
        Debug.Log(transform.name + ": LoadMainMenu", gameObject);
    }
}
