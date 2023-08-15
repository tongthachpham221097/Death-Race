using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeList : CopSpawnerList
{
    [Header("Bike List")]
    [SerializeField] public List<Transform> Bikes;
    
    protected override void PublicListTransform()
    {
        this.Bikes = this.listTransform;
    }

    protected override void OnEnable(){}

    public void OnEnableRamdomBike()
    {
        this.Bikes[1].gameObject.SetActive(true);
    }

}
