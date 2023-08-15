using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeList : CopSpawnerList
{
    [Header("Bike List")]
    [SerializeField] public List<Transform> Bikes;
    
    protected override void PublicTransforms()
    {
        this.Bikes = this.transforms;
    }

    protected override void OnEnable(){}

    public void OnEnableRamdomBike()
    {
        this.OnEnableRamdomObject();
    }

}
