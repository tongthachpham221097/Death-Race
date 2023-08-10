using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersCtrl : LoboMonoBehaviour
{
    [Header("Managers Ctrl")]

    private static ManagersCtrl _instance;
    public static ManagersCtrl Instance { get => _instance; }
    
    [SerializeField] private GameManager _gameManager;
    public GameManager GameManager => _gameManager;

    [SerializeField] private EffectManager _effectsManager;
    public EffectManager EffectsManager => _effectsManager;

    [SerializeField] private SoundManager _soundManager;
    public SoundManager SoundManager => _soundManager;

    [SerializeField] private UIManager _uiManager;
    public UIManager UIManager => _uiManager;

    protected override void Awake()
    {
        base.Awake();
        if (ManagersCtrl._instance != null) Debug.LogError("only 1 ManagersCtrl allow to exist");
        ManagersCtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGameManager();
        this.LoadEffectManager();
        this.LoadSoundManager();
        this.LoadUIManager();
    }

    void LoadGameManager()
    {
        if (this._gameManager != null) return;
        this._gameManager = GetComponentInChildren<GameManager>();
        Debug.LogWarning(transform.name + ": LoadGameManager", gameObject);
    }

    void LoadEffectManager()
    {
        if (this._effectsManager != null) return;
        this._effectsManager = GetComponentInChildren<EffectManager>();
        Debug.LogWarning(transform.name + ": LoadLevelsManager", gameObject);
    }

    void LoadSoundManager()
    {
        if (this._soundManager != null) return;
        this._soundManager = GetComponentInChildren<SoundManager>();
        Debug.LogWarning(transform.name + ": LoadSoundManager", gameObject);
    }

    void LoadUIManager()
    {
        if (this._uiManager != null) return;
        this._uiManager = GetComponentInChildren<UIManager>();
        Debug.LogWarning(transform.name + ": LoadUIManager", gameObject);
    }

}
