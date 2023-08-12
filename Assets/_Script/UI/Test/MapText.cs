using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapText : BaseText
{
    //[SerializeField] protected RoadCtrl levelsManager;
    //public RoadCtrl LevelsManager => levelsManager;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        //this.LoadLevelsManager();
    }
    //protected virtual void LoadLevelsManager()
    //{
    //    if (this.levelsManager != null) return;
    //    this.levelsManager = FindAnyObjectByType<RoadCtrl>();
    //    Debug.Log(transform.name + ": LoadLevelsManager", gameObject);
    //}
    protected virtual void FixedUpdate()
    {
        this.UpdateMap();
    }
    protected virtual void UpdateMap()
    {
        //text.text = "Map " + (this.levelsManager._level+1).ToString();
    }
}
