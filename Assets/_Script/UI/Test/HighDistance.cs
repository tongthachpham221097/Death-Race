using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighDistance : MonoBehaviour
{
    [SerializeField] protected Text highDistance;
    [SerializeField] protected DistanceText distanceText;
    protected virtual void Reset()
    {
        this.highDistance = GetComponent<Text>();
        this.distanceText = FindAnyObjectByType<DistanceText>();
    }
    protected virtual void Start()
    {
        this.EnableHighDistance();
    }
    public virtual void EnableHighDistance()
    {
        highDistance.text = "HighDistance: " + PlayerPrefs.GetInt("highDistance").ToString();
    }
}
