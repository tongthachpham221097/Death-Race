using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : LoboMonoBehaviour
{

    [SerializeField] private PlayerCtrl _playerCtrl;

    [Header("Avatar")]
    [SerializeField] private int _indexRider;
    [SerializeField] private int _indexMotobody;
    [SerializeField] private int _indexWeapon;
    [SerializeField] private int _indexTire;
    [Header("Rotate")]
    [SerializeField] private float _rotationSpeed = 1f;
    [SerializeField] private float _timeDelayRotate = 0.0001f;
    [SerializeField] private bool _isRotate = false;

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

    public void OnClickUserInfoStartRaceBtn()
    {
        this.OnEnablePlayerAvatars();
        this.UpdateRidersAnimation();
    }

    // Player Avatar
    public void OnEnablePlayerAvatars()
    {
        this.GetRidersList()[this._indexRider].gameObject.SetActive(true);
        this.GetMotoBodysList()[this._indexMotobody].gameObject.SetActive(true);
        this.GetWeaponsList()[this._indexWeapon].gameObject.SetActive(true);
        this.GetTiresList()[this._indexTire].gameObject.SetActive(true);
    }

    PlayerAvatars GetAvatars()
    {
        return this._playerCtrl.Avatars;
    }

    List<Transform> GetRidersList()
    {
        return this.GetAvatars().Riders.RidersList;
    }

    List<Transform> GetMotoBodysList()
    {
        return this.GetAvatars().MotoBodys.MotoBodysList;
    }

    List<Transform> GetTiresList()
    {
        return this.GetAvatars().Tires.TiresList;
    }

    public List<Transform> GetWeaponsList()
    {
        return this._playerCtrl.Avatars.Weapons.WeaponsList;
    }

    public PlayerAvatars GetPlayerAvatars()
    {
        return this._playerCtrl.Avatars;
    }

    public void SetIndexRider(int indexRider)
    {
        this._indexRider = indexRider;
    }

    public void SetIndexMotoBody(int indexMotobody)
    {
        this._indexMotobody = indexMotobody;
    }

    public void SetIndexWeapon(int indexWeapon)
    {
        this._indexWeapon = indexWeapon;
    }

    public void SetIndexTire(int indexTire)
    {
        this._indexTire = indexTire;
    }


    void UpdateRidersAnimation()
    {
        RiderAnimation riderAnimation = this.GetRiderAnimation();
        riderAnimation.UpdateRidersAnimation(this._indexRider, this._indexWeapon);
    }

    RiderAnimation GetRiderAnimation()
    {
        return this._playerCtrl.Avatars.RiderAnimation;
    }

    // Player Position
    public float GetPlayerPositionY()
    {
        return this.GetPlayerPosition().y;
    }

    public Vector3 GetPlayerPosition()
    {
        return this._playerCtrl.transform.position;
    }

    // Movement

    public void DecreaseSpeedMax(float value)
    {
        this._playerCtrl.Movement.DecreaseSpeedMax(value);
    }

    public void IncreaseSpeedMaxByTime()
    {
        this._playerCtrl.Movement.IncreaseSpeedMaxByTime();
    }

    public void DecreaseSpeedMaxByTime()
    {
        this._playerCtrl.Movement.DecreaseSpeedMaxByTime();
    }


    // Player Rotate

    public void Rotate()
    {
        this._playerCtrl.transform.Rotate(Vector3.forward * this._rotationSpeed * Time.deltaTime);
        InvokeRepeating(nameof(this.Rotatting), 0.1f, this._timeDelayRotate);
        this.DecreaseSpeedMaxByTime();
    }

    void Rotatting()
    {
        if (this._playerCtrl.transform.rotation.z < 0) this._isRotate = true;
        if (this._playerCtrl.transform.rotation.z >= 0 && this._isRotate == true)
        {
            this._playerCtrl.transform.rotation = Quaternion.identity;
            CancelInvoke(nameof(this.Rotatting));
            return;
        }
        this._playerCtrl.transform.Rotate(Vector3.forward * this._rotationSpeed * Time.deltaTime);
    }

}
