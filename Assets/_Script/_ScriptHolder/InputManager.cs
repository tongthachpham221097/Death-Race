using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance { get => _instance; }

    [SerializeField] public float pressHorizontal = 0f;
    [SerializeField] public float pressVertical = 0f;
    [SerializeField] public float pressKeySpace = 0f;
    [SerializeField] public bool pressKeyS = false;
    [SerializeField] public float pressKeyEscape = 0f;
    public bool countDowned = false;
    protected virtual void Awake()
    {
        if (InputManager._instance != null) Debug.LogError("only 1 InputManager allow to exist");
        InputManager._instance = this;
    }
    protected virtual void Update()
    {
        if (!this.countDowned) return;
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");
        this.pressKeySpace = Input.GetAxis("Jump");
        this.pressKeyS = Input.GetKey(KeyCode.S);
        this.pressKeyEscape = Input.GetAxis("Cancel");
    }
}
