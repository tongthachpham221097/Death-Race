using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    [SerializeField] public float pressHorizontal = 0f;
    [SerializeField] public float pressVertical = 0f;
    [SerializeField] public float pressKeySpace = 0f;
    [SerializeField] public bool pressKeyS = false;
    [SerializeField] public bool pressKeyEscape = false;
    
    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("only 1 InputManager allow to exist");
        InputManager.instance = this;
    }
    private void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");
        this.pressKeySpace = Input.GetAxis("Jump");
        this.pressKeyS = Input.GetKey(KeyCode.S);
        this.pressKeyEscape = Input.GetKey(KeyCode.Escape);
    }
}
