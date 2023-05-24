using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseLevelsManager : LoboMonoBehaviour
{
    public GameObject playerAvatars;
    public GameObject roadPrefab;
    [SerializeField] protected List<Transform> avatarObjects;
    [SerializeField] protected List<Transform> roadPrefabObjects;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerAvatars();
        this.LoadAvatarObjects();
        this.LoadRoadPrefab();
        this.LoadRoadPrefabObjects();
    }
    protected virtual void LoadPlayerAvatars()
    {
        if (this.playerAvatars != null) return;
        this.playerAvatars = GameObject.Find("PlayerAvatars");
        Debug.Log(transform.name + ": LoadPlayerAvatars", gameObject);
    }
    protected virtual void LoadRoadPrefab()
    {
        if (this.roadPrefab != null) return;
        this.roadPrefab = GameObject.Find("RoadPrefab");
        Debug.Log(transform.name + ": LoadRoadPrefab", gameObject);
    }
    protected virtual void LoadAvatarObjects()
    {
        if (this.avatarObjects.Count > 0) return;
        foreach (Transform avatar in playerAvatars.transform)
        {
            this.avatarObjects.Add(avatar);
        }
        Debug.Log(transform.name + ": LoadAvatarObjects", gameObject);
    }
    protected virtual void LoadRoadPrefabObjects()
    {
        if (this.roadPrefabObjects.Count > 0) return;
        foreach (Transform prefab in roadPrefab.transform)
        {
            this.roadPrefabObjects.Add(prefab);
        }
        Debug.Log(transform.name + ": LoadRoadPrefabObjects", gameObject);
    }
}
