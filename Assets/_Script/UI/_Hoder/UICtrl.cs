using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPauseMenu();
        this.LoadGameOverMenu();
    }
    protected virtual void LoadGameOverMenu()
    {
        if (this.gameOverMenu != null) return;
        this.gameOverMenu = GameObject.Find("GameOverMenu");
        Debug.Log(transform.name + ": LoadGameOverMenu", gameObject);
    }
    protected virtual void LoadPauseMenu()
    {
        if (this.pauseMenu != null) return;
        this.pauseMenu = GameObject.Find("PauseMenu");
        Debug.Log(transform.name + ": LoadPauseMenu", gameObject);
    }
}
