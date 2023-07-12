using UnityEngine;

public class MainCamera : LoboMonoBehaviour
{
    private static MainCamera _instance;
    public static MainCamera Instance { get => _instance; }

    [SerializeField] private Camera _mainCamera;
    public Camera Camera => _mainCamera;

    [SerializeField] private float _cameraSize;
    public float CameraSize => _cameraSize;

    protected override void Awake()
    {
        if (MainCamera._instance != null) Debug.LogError("only 1 MainCamera allow to exist");
        MainCamera._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this._mainCamera = Camera.main;
        this.GetCameraSize();
    }

    void GetCameraSize()
    {
        this._cameraSize = _mainCamera.orthographicSize;
    }
}
