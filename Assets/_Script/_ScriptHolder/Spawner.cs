using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : LoboMonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;
    public GameObject spawnPos;
    public List<GameObject> objects = new List<GameObject>();
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;
    public string prefabName = "";
    public int maxObj = 1;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPos();
        this.LoadObjPrefab();
    }
    protected virtual void LoadSpawnPos()
    {
        if (this.spawnPos != null) return;
        this.spawnPos = GameObject.Find("PlayerCtrl");
        Debug.Log(transform.name + ": LoadSpawnPos", gameObject);
    }
    protected virtual void LoadObjPrefab()
    {
        if (this.objPrefab != null) return;
        this.objPrefab = GameObject.Find(this.prefabName);
        Debug.Log(transform.name + ": LoadObjPrefab", gameObject);
    }
    protected virtual void Start()
    {
        this.objPrefab.SetActive(false);
    }
    protected virtual void Update()
    {
        this.Spawn();
        //this.CheckDead();
    }
    protected virtual GameObject Spawn()
    {
        if (this.objects.Count >= this.maxObj) return null;
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return null;
        this.spawnTimer = 0;

        Vector3 pos = this.spawnPos.transform.position;
        
        return this.Spawn(pos);
    }
    protected virtual GameObject Spawn(Vector3 pos)
    {
        GameObject obj = Instantiate(this.objPrefab);
        obj.transform.position = pos;
        obj.transform.parent = transform;
        obj.SetActive(true);
        this.objects.Add(obj);
        return obj;
    }
    protected virtual void CheckDead()
    {
        GameObject minion;
        for (int i = 0; i < this.objects.Count; i++)
        {
            minion = this.objects[i];
            if (minion == null) this.objects.RemoveAt(i);
        }
    }
}
