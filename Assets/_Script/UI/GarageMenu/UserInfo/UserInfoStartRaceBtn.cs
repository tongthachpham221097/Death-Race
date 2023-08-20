using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfoStartRaceBtn : BaseButton
{
    [Header("User Info StartRace Btn")]
    //[SerializeField] private int _indexTire;
    //[SerializeField] private int _indexMotobody;
    //[SerializeField] private int _indexRider;
    //[SerializeField] private int _indexWeapon;

    private PlayerAvatars _playerAvatars;
    
    protected override void OnClick()
    {
        this.SetIndexPlayerManager();
        
        ManagersCtrl.Instance.Player.OnEnablePlayerAvatars();
        this.DisableGarageMenu();
        this.GetPlayerAvatars();
        //this.OnEnablePlayerAvatars();
        //this.UpdateRidersAnimation();
    }

    void SetIndexPlayerManager()
    {
        //ManagersCtrl.Instance.PlayerManager.SetIndexAvatars();
    }

    int GetIndexRider()
    {
        RidersList riders = ManagersCtrl.Instance.UI.GetRidersList();
        return riders.GetIndexOnEnable();
    }

    void GetPlayerAvatars()
    {
        this._playerAvatars = ManagersCtrl.Instance.Player.GetPlayerAvatars();
    }

    //void OnEnablePlayerAvatars()
    //{
    //    this._playerAvatars.Riders.OnEnableGameObject(this._indexRider);
    //    this._playerAvatars.MotoBodys.OnEnableGameObject(this._indexMotobody);
    //    this._playerAvatars.Weapons.OnEnableGameObject(this._indexWeapon);
    //    this._playerAvatars.Tires.OnEnableGameObject(this._indexTire);
    //}

    //void UpdateRidersAnimation()
    //{
    //    RiderAnimation riderAnimation = this._playerAvatars.RiderAnimation;
    //    riderAnimation.UpdateRidersAnimation(this._indexRider, this._indexWeapon);
    //}

    //public void SaveIndexTire(int indexTire)
    //{
    //    this._indexTire = indexTire;
    //}

    //public void SaveIndexMotobody(int indexMotobody)
    //{
    //    this._indexMotobody = indexMotobody;
    //}

    //public void SaveIndexRider(int indexRider)
    //{
    //    this._indexRider = indexRider;
    //}

    //public void SaveIndexWeapon(int indexWeapon)
    //{
    //    this._indexWeapon = indexWeapon;
    //}

}
