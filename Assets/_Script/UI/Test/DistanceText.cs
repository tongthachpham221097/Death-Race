using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText : BaseText
{
    [Header("Distance Text")]
    [SerializeField] public int distance;
    [SerializeField] protected int highDistance = 0;
    protected virtual void Start()
    {
        this.highDistance = PlayerPrefs.GetInt("highDistance");
    }
    protected virtual void FixedUpdate()
    {
        this.GetDistance();
        this.OnEnableDistance();
    }
    public virtual void GetDistance()
    {
        //this.distance = (int)TextCtrl.PlayerCollider.transform.parent.position.y;
    }
    public virtual void OnEnableDistance()
    {
        text.text = "Distance: " + this.distance.ToString();
    }
    public virtual void SetHighDistance()
    {
        if (this.distance <= this.highDistance) return;
        this.highDistance = this.distance;
        PlayerPrefs.SetInt("highDistance", highDistance);
    }
    public virtual void SetLastDistance()
    {
        PlayerPrefs.SetInt("lastDistance", this.distance);
    }
}
