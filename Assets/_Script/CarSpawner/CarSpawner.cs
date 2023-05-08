using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : Spawner2
{
    private static CarSpawner instance;
    public static CarSpawner Instance { get => instance; }

    public static string carOne = "Car_1";
    protected override void Awake()
    {
        base.Awake();
        if (CarSpawner.instance != null) Debug.LogError("only 1 CarSpawner allow to exist");
        CarSpawner.instance = this;
    }
}
