using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfoStartRaceBtn : BaseButton
{
    //[Header("User Info StartRace Btn")]
    
    protected override void OnClick()
    {
        this.SetIndexPlayerAvatars();
        this.GetPlayerManager().OnClickUserInfoStartRaceBtn();
        this.DisableGarageMenu();
    }

    void SetIndexPlayerAvatars()
    {
        this.GetPlayerManager().SetIndexRider(this.GetIndexRider());
        this.GetPlayerManager().SetIndexMotoBody(this.GetIndexMotoBody());
        this.GetPlayerManager().SetIndexWeapon(this.GetIndexWeapon());
        this.GetPlayerManager().SetIndexTire(this.GetIndexTire());
    }

    int GetIndexRider()
    {
        RidersList riders = this.GetUIManager().GetRidersList();
        return riders.GetIndexOnEnable();
    }

    int GetIndexMotoBody()
    {
        MotoBodysList motoBodys = this.GetUIManager().GetMotoBodysList();
        return motoBodys.GetIndexOnEnable();
    }

    int GetIndexWeapon()
    {
        WeaponsList weapons = this.GetUIManager().GetWeaponsList();
        return weapons.GetIndexOnEnable();
    }

    int GetIndexTire()
    {
        TiresList tires = this.GetUIManager().GetTiresList();
        return tires.GetIndexOnEnable();
    }

    UIManager GetUIManager()
    {
        return ManagersCtrl.Instance.UI;
    }

    PlayerManager GetPlayerManager()
    {
        return ManagersCtrl.Instance.Player;
    }

}
