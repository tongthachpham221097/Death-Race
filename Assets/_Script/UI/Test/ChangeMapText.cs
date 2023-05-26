using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMapText : BaseText
{
    [SerializeField] protected LevelsManager levelsManager;
    public LevelsManager LevelsManager => levelsManager;

    [SerializeField] protected DistanceText distanceText;
    public DistanceText DistanceText => distanceText;

    [SerializeField] protected int changeMap; 
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadLevelsManager();
        this.LoadDistanceText();
    }
    protected virtual void LoadLevelsManager()
    {
        if (this.levelsManager != null) return;
        this.levelsManager = FindAnyObjectByType<LevelsManager>();
        Debug.Log(transform.name + ": LoadLevelsManager", gameObject);
    }
    protected virtual void LoadDistanceText()
    {
        if (this.distanceText != null) return;
        this.distanceText = FindAnyObjectByType<DistanceText>();
        Debug.Log(transform.name + ": LoadDistanceText", gameObject);
    }
    protected virtual void FixedUpdate()
    {
        this.UpdateChangeMap();
    }
    protected virtual void UpdateChangeMap()
    {
        this.changeMap = this.levelsManager.distanceLevelUp - this.distanceText.distance;
        text.text = "Change Map: " + this.changeMap.ToString();
    }
}
