using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCtrl : LoboMonoBehaviour
{
    [Header("Game Manager Ctrl")]
    [SerializeField] protected DistanceText distanceText;
    public DistanceText DistanceText => distanceText;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDistanceText();
    }
    protected virtual void LoadDistanceText()
    {
        if (this.distanceText != null) return;
        this.distanceText = FindAnyObjectByType<DistanceText>();
        Debug.Log(transform.name + ": LoadDistanceText", gameObject);
    }
}
