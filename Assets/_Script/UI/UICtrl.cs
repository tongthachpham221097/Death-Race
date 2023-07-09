using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    [Header("UI Ctrl")]

    private GameObject _carSpawner;
    private AudioSource _soundRacing;

    [SerializeField] private UIMenuCtrl _uiMenuCtrl;
    public UIMenuCtrl UIMenuCtrl => _uiMenuCtrl;
    
    [SerializeField] private PlayerCollider _playerCollider;
    public PlayerCollider PlayerCollider => _playerCollider;

    [SerializeField] private DistanceTextGO _distanceTextGO;
    public DistanceTextGO DistanceTextGO => _distanceTextGO;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCollider();
        this.LoadDistanceTextGO();
        this.LoadCarSpawner();
        this.LoadSoundRacing();
        this.LoadUIMenuCtrl();
    }
    
    protected virtual void LoadPlayerCollider()
    {
        if (this._playerCollider != null) return;
        this._playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
    protected virtual void LoadDistanceTextGO()
    {
        if (this._distanceTextGO != null) return;
        this._distanceTextGO = FindAnyObjectByType<DistanceTextGO>();
        Debug.Log(transform.name + ": LoadDistanceText", gameObject);
    }
    
    protected virtual void LoadCarSpawner()
    {
        if (this._carSpawner != null) return;
        this._carSpawner = GameObject.Find("CarSpawner");
        Debug.Log(transform.name + ": LoadCarSpawner", gameObject);
    }
    protected virtual void LoadSoundRacing()
    {
        if (this._soundRacing != null) return;
        this._soundRacing = GameObject.Find("SoundRacing").GetComponent<AudioSource>();
        Debug.Log(transform.name + ": LoadSoundRacing", gameObject);
    }

    protected virtual void LoadUIMenuCtrl()
    {
        if (this._uiMenuCtrl != null) return;
        this._uiMenuCtrl = GetComponentInChildren<UIMenuCtrl>();
        Debug.Log(transform.name + ": LoadUIMenuCtrl", gameObject);
    }
}
