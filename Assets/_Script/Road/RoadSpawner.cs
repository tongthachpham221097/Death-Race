using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoadSpawner : LoboMonoBehaviour
{
    [SerializeField] protected RoadCtrl roadCtrl;
    public RoadCtrl RoadCtrl { get => roadCtrl; }

    protected GameObject roadPrefab;
    protected GameObject roadSpawnPos;
    protected float distance = 0;
    protected GameObject roadCurrent;
    protected int roadLayerOrder = 0;

    protected override void Awake()
    {
        this.roadPrefab = GameObject.Find("RoadPrefab");
        this.roadSpawnPos = GameObject.Find("RoadSpawnPos");
        this.roadPrefab.SetActive(false);

        //this.roadCurrent = this.roadPrefab;
        this.roadLayerOrder = (int) this.roadPrefab.transform.position.z;

        this.Spawn(this.roadPrefab.transform.position);
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRoadCtrl();
    }
    protected virtual void LoadRoadCtrl()
    {
        if (this.roadCtrl != null) return;
        this.roadCtrl = GetComponentInParent<RoadCtrl>();
        Debug.Log(transform.name + ": LoadRoadCtrl", gameObject);
    }
    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(this.roadCtrl.PlayerCtrl.transform.position, this.roadCurrent.transform.position);
        if (this.distance > 40) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;
        pos.x = 0;
        pos.z = this.roadLayerOrder;

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
