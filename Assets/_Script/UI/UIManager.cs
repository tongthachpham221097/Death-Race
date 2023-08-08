using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : LoboMonoBehaviour
{
    [Header("UI Manager")]
    [SerializeField] private UICtrl _uiCtrl;
    public UICtrl UICtrl => _uiCtrl;
    protected override void Awake()
    {
        base.Awake();
        //this._uiCtrl.UIMenuCtrl.GameOverMenu.SetActive(false);
        //this._uiCtrl.UIMenuCtrl.carSpawner.SetActive(false);
    }
    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUICtrl();
    }
    protected virtual void LoadUICtrl()
    {
        if (this._uiCtrl != null) return;
        this._uiCtrl = GetComponentInChildren<UICtrl>();
        Debug.Log(transform.name + ": LoadUICtrl", gameObject);
    }

    protected virtual void Update()
    {
        //if (this._uiCtrl.PlayerCollider.isGameOver == true)
        //{
        //    //this._uiCtrl.soundRacing.mute = true;
        //    this.OnEnableGameOverMenu();
        //}
    }

    //protected virtual void OnEnableGameOverMenu()
    //{
    //    this._uiCtrl.UIMenuCtrl.GameOverMenu.SetActive(true);
    //    this._uiCtrl.DistanceTextGO.GetDistance();
    //    this._uiCtrl.DistanceTextGO.OnEnableDistance();
    //    Time.timeScale = 0f;
    //}
}
