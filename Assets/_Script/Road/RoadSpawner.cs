using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadSpawner : BaseRoadSpawner
{
    protected float distance = 0;
    protected GameObject roadCurrent;
    protected int roadLayerOrder = 0;

    protected override void Awake()
    {
        //this.roadLayerOrder = (int) this.roadPrefab.transform.position.z;

        this.Spawn(this.roadPrefab.transform.position);
    }
    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(this.playerCtrl.transform.position, this.roadCurrent.transform.position);
        if (this.distance > 40) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.playerCtrl.transform.position;
        pos.x = 0;
        //pos.z = this.roadLayerOrder;
        pos.y += 40;
        this.Spawn(pos);
        this.roadCurrent = Instantiate(this.roadPrefab, pos, this.roadPrefab.transform.rotation);
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.roadCurrent = Instantiate(this.roadPrefab, position, this.roadPrefab.transform.rotation);
        this.roadCurrent.transform.parent = transform;
        this.roadCurrent.SetActive(true);
    }
}
