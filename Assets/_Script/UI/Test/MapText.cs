using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapText : BaseText
{
    [SerializeField] protected LevelsManager levelsManager;
    public LevelsManager LevelsManager => levelsManager;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadLevelsManager();
    }
    protected virtual void LoadLevelsManager()
    {
        if (this.levelsManager != null) return;
        this.levelsManager = FindAnyObjectByType<LevelsManager>();
        Debug.Log(transform.name + ": LoadLevelsManager", gameObject);
    }
    protected virtual void FixedUpdate()
    {
        this.UpdateMap();
    }
    protected virtual void UpdateMap()
    {
        text.text = "Map " + (this.levelsManager.level+1).ToString();
    }
}
