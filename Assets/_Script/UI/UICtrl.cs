using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    
    private static UICtrl _instance;
    public static UICtrl Instance { get => _instance; }

    [SerializeField] private GarageMenu _garageMenu;
    public GarageMenu GarageMenu => _garageMenu;

    protected override void Awake()
    {
        base.Awake();
        if (UICtrl._instance != null) Debug.LogError("only 1 UICtrl allow to exist");
        UICtrl._instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGarageMenu();
    }

    void LoadGarageMenu()
    {
        if (this._garageMenu != null) return;
        this._garageMenu = GetComponentInChildren<GarageMenu>();
        Debug.Log(transform.name + ": LoadGarageMenu", gameObject);
    }
    


}
