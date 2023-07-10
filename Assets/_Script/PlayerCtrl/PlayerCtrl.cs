using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : LoboMonoBehaviour
{
    private static PlayerCtrl _instance;
    public static PlayerCtrl Instance { get => _instance; }

    protected override void Awake()
    {
        if (PlayerCtrl._instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl._instance = this;
    }
    
}
