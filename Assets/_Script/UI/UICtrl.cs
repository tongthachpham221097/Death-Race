using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public GameObject mainMenu;
    public GameObject carSpawner;
    public AudioSource soundRacing;

    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider => playerCollider;

    [SerializeField] protected DistanceTextGO distanceTextGO;
    public DistanceTextGO DistanceTextGO => distanceTextGO;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPauseMenu();
        this.LoadGameOverMenu();
        this.LoadPlayerCollider();
        this.LoadDistanceTextGO();
        this.LoadMainMenu();
        this.LoadCarSpawner();
        this.LoadSoundRacing();
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
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
    protected virtual void LoadDistanceTextGO()
    {
        if (this.distanceTextGO != null) return;
        this.distanceTextGO = FindAnyObjectByType<DistanceTextGO>();
        Debug.Log(transform.name + ": LoadDistanceText", gameObject);
    }
    protected virtual void LoadMainMenu()
    {
        if (this.mainMenu != null) return;
        this.mainMenu = GameObject.Find("MainMenu");
        Debug.Log(transform.name + ": LoadMainMenu", gameObject);
    }
    protected virtual void LoadCarSpawner()
    {
        if (this.carSpawner != null) return;
        this.carSpawner = GameObject.Find("CarSpawner");
        Debug.Log(transform.name + ": LoadCarSpawner", gameObject);
    }
    protected virtual void LoadSoundRacing()
    {
        if (this.soundRacing != null) return;
        this.soundRacing = GameObject.Find("SoundRacing").GetComponent<AudioSource>();
        Debug.Log(transform.name + ": LoadSoundRacing", gameObject);
    }
}
