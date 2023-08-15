using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopSpawnerCar : CopSpawnerList
{
    
    [SerializeField] public List<Transform> Cars;

    protected override void PublicTransforms()
    {
        this.Cars = this.transforms;
    }

}
