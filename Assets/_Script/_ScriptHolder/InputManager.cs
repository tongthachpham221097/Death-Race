using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance { get => _instance; }

    [SerializeField] private float _pressHorizontal = 0f;
    public float PressHorizontal => _pressHorizontal;

    [SerializeField] private float _pressVertical = 0f;
    public float PressVertical => _pressVertical;

    [SerializeField] private bool _pressKeyEsc = false;
    public bool PressKeyEsc => _pressKeyEsc;

    [SerializeField] private bool _pressSpace = false;
    public bool PressSpace => _pressSpace;

    [SerializeField] private bool _pressKeyS = false;
    public bool PressKeyS => _pressKeyS;

    [SerializeField] private bool _pressCtrl = false;
    public bool PressCtrl => _pressCtrl;

    [SerializeField] private bool _countDowned = false;
    public bool CountDowned => _countDowned;

    protected virtual void Awake()
    {
        if (InputManager._instance != null) Debug.LogError("only 1 InputManager allow to exist");
        InputManager._instance = this;
    }
    protected virtual void Update()
    {
        //if (!this._countDowned) return;
        this._pressHorizontal = Input.GetAxis("Horizontal");
        this._pressVertical = Input.GetAxis("Vertical");
        this._pressSpace = Input.GetButtonDown("Jump");
        this._pressKeyS = Input.GetKey(KeyCode.S);
        this._pressKeyEsc = Input.GetButtonDown("Cancel");
        this._pressCtrl = Input.GetButton("Fire1");
    }
}
