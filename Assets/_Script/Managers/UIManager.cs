using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : LoboMonoBehaviour
{

    [SerializeField] private UICtrl _uiCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUICtrl();
    }

    void LoadUICtrl()
    {
        if (this._uiCtrl != null) return;
        this._uiCtrl = FindAnyObjectByType<UICtrl>();
        Debug.Log(transform.name + ": LoadUICtrl", gameObject);
    }


    // MainMenu
    public void OnEnableMainMenu()
    {
        this._uiCtrl.MainMenu.gameObject.SetActive(true);
    }

    public void DisableMainMenu()
    {
        this._uiCtrl.MainMenu.gameObject.SetActive(false);    
    }

    // GarageMenu

    public void OnEnableGarageMenu()
    {
        this.GetGarageMenu().gameObject.SetActive(true);
    }
    
    public void DisableGarageMenu()
    {
        this.GetGarageMenu().gameObject.SetActive(false);
    }

    public GarageMenu GetGarageMenu()
    {
        return this._uiCtrl.GarageMenu;
    }
    
    public UserInfo GetUserInfo()
    {
        return this.GetGarageMenu().UserInfo;
    }

    public UserInfoAvatar GetUserInfoAvatar()
    {
        return this.GetUserInfo().UserInfoAvatar;
    }

    public TiresList GetTiresList()
    {
        return this.GetUserInfoAvatar().TiresList;
    }

    public RidersList GetRidersList()
    {
        return this.GetUserInfoAvatar().RidersList;
    }

    public GarageMenuItem GetGarageMenuItem()
    {
        return this.GetGarageMenu().GarageMenuItem;
    }    

    public ItemBar GetItemBar()
    {
        return this.GetGarageMenuItem().ItemBar;
    }    

    public ItemBarPage GetItemBarPage()
    {
        return this.GetItemBar().ItemBarPage;
    }

    public ItemBg GetItemBg()
    {
        return this.GetItemBar().ItemBg;
    }    

    public ItemBgOff GetItemBgOff()
    {
        return this.GetItemBg().ItemBgOff;
    }

    // ChooseRaceMenu

    public void DisableChooseRaceMenu()
    {
        this.GetChooseRaceMenu().gameObject.SetActive(false);
    }

    public ChooseRaceMenu GetChooseRaceMenu()
    {
        return this._uiCtrl.ChooseRaceMenu;
    }

    public ChooseRaceList GetChooseRaceList()
    {
        return this.GetChooseRaceMenu().ChooseRaceList;
    }

}
