using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTextsManager : LoboMonoBehaviour
{
    public GameObject highDistance;
    public GameObject lastDistance;
    public GameObject changeMapText;
    public GameObject mapText;
    protected override void LoadComponents()
    {
        this.LoadHighDistance();
        this.LoadLastDistance();
        this.LoadChangeMapText();
        this.LoadMapText();
    }
    protected virtual void LoadHighDistance()
    {
        if (this.highDistance != null) return;
        this.highDistance = GameObject.Find("HighDistance");
        Debug.Log(transform.name + ": LoadHighDistance", gameObject);
    }
    protected virtual void LoadLastDistance()
    {
        if (this.lastDistance != null) return;
        this.lastDistance = GameObject.Find("LastDistance");
        Debug.Log(transform.name + ": LoadLastDistance", gameObject);
    }
    protected virtual void LoadChangeMapText()
    {
        if (this.changeMapText != null) return;
        this.changeMapText = GameObject.Find("ChangeMapText");
        Debug.Log(transform.name + ": LoadChangeMapText", gameObject);
    }
    protected virtual void LoadMapText()
    {
        if (this.mapText != null) return;
        this.mapText = GameObject.Find("MapText");
        Debug.Log(transform.name + ": LoadMapText", gameObject);
    }
}
