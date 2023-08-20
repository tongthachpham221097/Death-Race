using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderAnimation : LoboMonoBehaviour
{
    [SerializeField] private PlayerAvatarsRiders _playerAvatarsRiders;

    [SerializeField] private Animator _animator;
    [SerializeField] private int _indexWeapon;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerAvatarsRiders();
    }

    void LoadPlayerAvatarsRiders()
    {
        if (this._playerAvatarsRiders != null) return;
        this._playerAvatarsRiders = GetComponent<PlayerAvatarsRiders>();
        Debug.LogWarning(transform.name + ": LoadPlayerAvatarsRiders", gameObject);
    }

    public void UpdateRidersAnimation(int indexRider, int indexWeapon)
    {
        this.GetAnimator(indexRider);
        this._indexWeapon = indexWeapon;
        this.SetChooseHitAnimationCtrl();
    }
    void GetAnimator(int indexRider)
    {
        Transform rider = this._playerAvatarsRiders.RidersList[indexRider];
        this._animator = rider.GetComponent<Animator>();
    }

    void SetChooseHitAnimationCtrl()
    {
        this._animator.SetInteger("chooseHit", this._indexWeapon + 1);
    }

    private void Update()
    {
        this.SetPressHorizontal();
        this.SetIsAttacking();
    }

    void SetPressHorizontal()
    {
        if (InputManager.Instance.PressHorizontal == 0) return;
        float pressHorizontal = InputManager.Instance.PressHorizontal;
        this._animator.SetFloat("pressHorizontal", pressHorizontal);
    }    

    void SetIsAttacking()
    {
        if (this._animator == null) return;
        bool isAttack = InputManager.Instance.PressCtrl;
        this._animator.SetBool("isAttack", isAttack);
        this.SetActiveWeapon(isAttack);
    }

    void SetActiveWeapon(bool isAttack)
    {
        List<Transform> weaponsList = this.GetWeaponsList();
        weaponsList[this._indexWeapon].gameObject.SetActive(!isAttack);
    }

    List<Transform> GetWeaponsList()
    {
        return ManagersCtrl.Instance.Player.GetWeaponsList();
    }

}
