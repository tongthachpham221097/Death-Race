using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : LoboMonoBehaviour
{

    [SerializeField] private PlayerCtrl _playerCtrl;

    [SerializeField] private int _indexRider;
    [SerializeField] private int _indexMotobody;
    [SerializeField] private int _indexWeapon;
    [SerializeField] private int _indexTire;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }

    void LoadPlayerCtrl()
    {
        if (this._playerCtrl != null) return;
        this._playerCtrl = FindAnyObjectByType<PlayerCtrl>();
        Debug.Log(transform.name + ": LoadPlayerCtrl", gameObject);
    }

    public void OnEnablePlayerAvatars()
    {
        this._playerCtrl.Avatars.gameObject.SetActive(true);
    }

    public List<Transform> GetWeaponsList()
    {
        return this._playerCtrl.Avatars.Weapons.PlayerAvatarsWeaponsList;
    }

    public PlayerAvatars GetPlayerAvatars()
    {
        return this._playerCtrl.Avatars;
    }

    public void SetIndexAvatars(int rider, int motobody, int weapon, int tire)
    {

    }

    public float GetPlayerPositionY()
    {
        return this.GetPlayerPosition().y;
    }

    public Vector3 GetPlayerPosition()
    {
        return this._playerCtrl.transform.position;
    }


}
