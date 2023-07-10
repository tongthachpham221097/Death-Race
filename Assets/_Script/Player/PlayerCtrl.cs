using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : LoboMonoBehaviour
{
    private static PlayerCtrl _instance;
    public static PlayerCtrl Instance { get => _instance; }

    [SerializeField] private PlayerAvatars _playerAvatars;
    public PlayerAvatars PlayerAvatars { get => _playerAvatars; }

    [SerializeField] private PlayerMovement _playerMovement;
    public PlayerMovement PlayerMovement { get => _playerMovement; }

    [SerializeField] private PlayerPickUpItem _playerPickUpItem;
    public PlayerPickUpItem PlayerPickUpItem { get => _playerPickUpItem; }

    protected override void Awake()
    {
        if (PlayerCtrl._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerAvatars();
        this.LoadPlayerMovement();
        this.LoadPlayerPickUpItem();
    }

    protected virtual void LoadPlayerAvatars()
    {
        if (this._playerAvatars != null) return;
        this._playerAvatars = GetComponentInChildren<PlayerAvatars>();
        Debug.Log(transform.name + ": LoadPlayerAvatars", gameObject);
    }

    protected virtual void LoadPlayerMovement()
    {
        if (this._playerMovement != null) return;
        this._playerMovement = GetComponentInChildren<PlayerMovement>();
        Debug.Log(transform.name + ": LoadPlayerMovement", gameObject);
    }

    protected virtual void LoadPlayerPickUpItem()
    {
        if (this._playerPickUpItem != null) return;
        this._playerPickUpItem = GetComponentInChildren<PlayerPickUpItem>();
        Debug.Log(transform.name + ": LoadPlayerPickUpItem", gameObject);
    }

}
