using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : LoboMonoBehaviour
{
    private static PlayerCtrl _instance;
    public static PlayerCtrl Instance { get => _instance; }

    [SerializeField] protected UICtrl uiCtrl;
    public UICtrl UICtrl => uiCtrl;
    protected override void Awake()
    {
        if (PlayerCtrl._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl._instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUICtrl();
    }
    protected virtual void LoadUICtrl()
    {
        if (this.uiCtrl != null) return;
        this.uiCtrl = FindAnyObjectByType<UICtrl>();
        Debug.Log(transform.name + ": LoadUICtrl", gameObject);
    }
}
