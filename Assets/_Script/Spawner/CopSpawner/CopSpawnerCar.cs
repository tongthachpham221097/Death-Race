using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopSpawnerCar : CopSpawnerList
{
    
    [SerializeField] public List<Transform> Cars;

    protected override void PublicListTransform()
    {
        this.Cars = this.listTransform;
    }

}
