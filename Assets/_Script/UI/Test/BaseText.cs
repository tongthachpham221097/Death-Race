using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseText : LoboMonoBehaviour
{
    [Header("Base Text")]
    [SerializeField] protected Text text;
    public Text Text => text;

    [SerializeField] protected TextCtrl textCtrl;
    public TextCtrl TextCtrl { get => textCtrl; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadText();
        this.LoadTextCtrl();
    }
    protected virtual void LoadText()
    {
        this.text = GetComponent<Text>();
    }
    protected virtual void LoadTextCtrl()
    {
        if (this.textCtrl != null) return;
        this.textCtrl = FindAnyObjectByType<TextCtrl>();
        Debug.Log(transform.name + ": LoadTextCtrl", gameObject);
    }
}
