using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseText : LoboMonoBehaviour
{
    [Header("Base Text")]
    [SerializeField] protected Text text;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadText();
    }

    void LoadText()
    {
        this.text = GetComponent<Text>();
    }
    
}
