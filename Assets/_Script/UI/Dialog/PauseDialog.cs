using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseDialog : MonoBehaviour
{
    public GameObject pauseDialog;
    protected virtual void Awake()
    {
        this.pauseDialog = GameObject.Find("PauseDialog");
    }
    protected virtual void Update()
    {
        if (InputManager.Instance.pressKeyEscape) this.pauseDialog.SetActive(true);
    }
}
