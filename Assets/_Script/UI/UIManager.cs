using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : LoboMonoBehaviour
{
    static public UIManager instance;
    [SerializeField] protected UICtrl uiCtrl;
    public UICtrl UICtrl => uiCtrl;
    protected override void Awake()
    {
        base.Awake();
        UIManager.instance = this;
        this.uiCtrl.gameOverMenu.SetActive(false);
        this.uiCtrl.carSpawner.SetActive(false);
    }
    protected virtual void Update()
    {
        if(this.uiCtrl.PlayerCollider.isGameOver == true) this.OnEnableGameOverMenu();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUICtrl();
    }
    protected virtual void LoadUICtrl()
    {
        if (this.uiCtrl != null) return;
        this.uiCtrl = GetComponent<UICtrl>();
        Debug.Log(transform.name + ": LoadUICtrl", gameObject);
    }
    protected virtual void OnEnableGameOverMenu()
    {
        this.uiCtrl.gameOverMenu.SetActive(true);
        this.uiCtrl.DistanceTextGO.GetDistance();
        this.uiCtrl.DistanceTextGO.OnEnableDistance();
        Time.timeScale = 0f;
    }
}
