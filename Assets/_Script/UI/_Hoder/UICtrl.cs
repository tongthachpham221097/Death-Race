using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverMenu;

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
}
