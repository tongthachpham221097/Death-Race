using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboMonoBehaviour
{
    public GameObject buttonRestart;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButtonRestart();
    }
    protected virtual void LoadButtonRestart()
    {
        if (this.buttonRestart != null) return;
        this.buttonRestart = GameObject.Find("ButtonRestart");
        Debug.Log(transform.name + ": LoadBnRestart", gameObject);
    }
}
