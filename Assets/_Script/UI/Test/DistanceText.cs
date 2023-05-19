using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText : TestManager
{
    [SerializeField] protected Text distanceText;
    [SerializeField] public int distance;
    [SerializeField] public int lastDistance = 0;
    [SerializeField] public int highDistance = 0;
    protected override void Reset()
    {
        base.Reset();
        this.distanceText = GetComponent<Text>();
    }
    protected virtual void Start()
    {
        //highDistance = PlayerPrefs.GetInt("highDistance");
        // may be use PlayerPrefs.DeleteAll();
    }
    protected virtual void FixedUpdate()
    {
        this.DistanceRace();
        //PlayerPrefs.DeleteAll();
        this.SetHighDistance();
        this.SetLastDistance();
    }
    protected virtual void DistanceRace()
    {
        this.distance = (int)playerCollider.transform.parent.position.y;
        distanceText.text = "Distance: " + this.distance.ToString();
    }
    protected virtual void SetHighDistance()
    {
        if (this.distance <= this.highDistance) return;
        this.highDistance = this.distance;
        PlayerPrefs.SetInt("highDistance", highDistance);
    }
    protected virtual void SetLastDistance()
    {
        this.lastDistance = this.distance;
        PlayerPrefs.SetInt("lastDistance", lastDistance);
    }
}
