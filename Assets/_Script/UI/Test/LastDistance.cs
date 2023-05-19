using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastDistance : MonoBehaviour
{
    [SerializeField] protected Text lastDistance;
    
    protected virtual void Reset()
    {
        this.lastDistance = GetComponent<Text>();
    }
    protected virtual void Start()
    {
        this.EnableLastDistance();
    }
    public virtual void EnableLastDistance()
    {
        lastDistance.text = "LastDistance: " + PlayerPrefs.GetInt("lastDistance").ToString();
    }

}
