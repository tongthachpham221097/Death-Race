using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfoStartRaceBtn : BaseButton
{
    [Header("User Info StartRace Btn")]
    [SerializeField] private int _indexTire;
    [SerializeField] private int _indexMotobody;
    [SerializeField] private int _indexRider;
    [SerializeField] private int _indexWeapon;
    
    protected override void OnClick()
    {
        this.DisableGameObject(transform.parent.parent.gameObject);
        // CAll player ctrl
    }

    public void SaveIndexTire(int indexTire)
    {
        this._indexTire = indexTire;
    }

    public void SaveIndexMotobody(int indexMotobody)
    {
        this._indexMotobody = indexMotobody;
    }

    public void SaveIndexRider(int indexRider)
    {
        this._indexRider = indexRider;
    }

    public void SaveIndexWeapon(int indexWeapon)
    {
        this._indexWeapon = indexWeapon;
    }

}
