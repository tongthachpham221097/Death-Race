using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCtrl : LoboMonoBehaviour
{
    [Header("Game Manager Ctrl")]
    [SerializeField] protected DistanceText distanceText;
    public DistanceText DistanceText => distanceText;

    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider => playerCollider;

    public GameObject pauseMenu;
    public GameObject mainMenu;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDistanceText();
        this.LoadPlayerCollider();
        this.LoadPauseMenu();
        this.LoadMainMenu();
    }
    protected virtual void LoadDistanceText()
    {
        if (this.distanceText != null) return;
        this.distanceText = FindAnyObjectByType<DistanceText>();
        Debug.Log(transform.name + ": LoadDistanceText", gameObject);
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
    protected virtual void LoadPauseMenu()
    {
        if (this.pauseMenu != null) return;
        this.pauseMenu = GameObject.Find("PauseMenu");
        Debug.Log(transform.name + ": LoadMainMenu", gameObject);
    }
    protected virtual void LoadMainMenu()
    {
        if (this.mainMenu != null) return;
        this.mainMenu = GameObject.Find("MainMenu");
        Debug.Log(transform.name + ": LoadMainMenu", gameObject);
    }
}
