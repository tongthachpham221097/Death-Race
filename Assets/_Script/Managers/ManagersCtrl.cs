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

    [SerializeField] private LevelsManager _levelsManager;
    public LevelsManager LevelsManager => _levelsManager;

    [SerializeField] private EffectManager _effectsManager;
    public EffectManager EffectsManager => _effectsManager;

    [SerializeField] private SoundManager _soundManager;
    public SoundManager SoundManager => _soundManager;

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
        this.LoadLevelsManager();
        this.LoadEffectManager();
        this.LoadSoundManager();
    }

    protected virtual void LoadGameManager()
    {
        if (this._gameManager != null) return;
        this._gameManager = GetComponentInChildren<GameManager>();
        Debug.LogWarning(transform.name + ": LoadGameManager", gameObject);
    }

    protected virtual void LoadLevelsManager()
    {
        if (this._levelsManager != null) return;
        this._levelsManager = GetComponentInChildren<LevelsManager>();
        Debug.LogWarning(transform.name + ": LoadLevelsManager", gameObject);
    }

    protected virtual void LoadEffectManager()
    {
        if (this._effectsManager != null) return;
        this._effectsManager = GetComponentInChildren<EffectManager>();
        Debug.LogWarning(transform.name + ": LoadLevelsManager", gameObject);
    }

    protected virtual void LoadSoundManager()
    {
        if (this._soundManager != null) return;
        this._soundManager = GetComponentInChildren<SoundManager>();
        Debug.LogWarning(transform.name + ": LoadSoundManager", gameObject);
    }

}
