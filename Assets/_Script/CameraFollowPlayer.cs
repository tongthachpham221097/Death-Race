using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : LoboMonoBehaviour
{
    [SerializeField] protected Transform playerCtrl;
    [SerializeField] protected float defaultPosZ = -10f;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GameObject.Find("PlayerCtrl").transform;
        Debug.Log(transform.name + ": LoadPlayerCtrl", gameObject);
    }
    protected virtual void Update()
    {
        this.Following();
    }
    protected virtual void Following()
    {
        transform.position = new Vector3(0, this.playerCtrl.position.y, this.defaultPosZ);
    }
}
