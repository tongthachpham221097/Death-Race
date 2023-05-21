using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : LoboMonoBehaviour
{
    static public UIManager instance;
    [SerializeField] protected UICtrl uiCtrl;
    public UICtrl UICtrl => uiCtrl;
    //public GameObject gamePlay;
    //public GameObject gameStarting;
    protected override void Awake()
    {
        base.Awake();
        UIManager.instance = this;
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

    protected override void Start()
    {
        base.Start();
        //this.uiCtrl.restartButton.SetActive(false);
        //this.uiCtrl.pauseButton.SetActive(true);
        //this.uiCtrl.pauseDialog.SetActive(false);
        this.uiCtrl.gameOverMenu.SetActive(false);
        this.uiCtrl.pauseMenu.SetActive(false);
    }
}
