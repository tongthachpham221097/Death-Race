using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : BaseLevelsManager
{
    [SerializeField] public int level = 0;
    [SerializeField] public int distanceChangeMap = 500;
    [SerializeField] public int distanceLevelUp = 500;
    protected override void Awake()
    {
        this.HideAvatars();
        this.HideRoadPrefabs();
    }
    protected virtual void Start()
    {
        avatarObjects[0].gameObject.SetActive(true);
        roadPrefabObjects[0].gameObject.SetActive(true);
    }
    protected virtual void FixedUpdate()
    {
        this.UpdateLevel();
    }
    protected virtual void HideAvatars()
    {
        foreach (Transform avatarObject in avatarObjects)
        {
            avatarObject.gameObject.SetActive(false);
        }
    }
    protected virtual void HideRoadPrefabs()
    {
        foreach (Transform roadPrefabObject in roadPrefabObjects)
        {
            roadPrefabObject.gameObject.SetActive(false);
        }
    }
    protected virtual void UpdateLevel()
    {
        int currentLevel = (int)playerAvatars.transform.parent.position.y / this.distanceChangeMap;
        if (currentLevel == this.level) return;
        if (currentLevel >= this.avatarObjects.Count) return;
        this.ShowPlayerAvatar(currentLevel);
        this.ShowRoadPrefab(currentLevel);
        this.UpdateDistanceLevelUp();
        this.level = currentLevel;
    }
    protected virtual void ShowPlayerAvatar(int currentLevel)
    {
        this.avatarObjects[currentLevel].gameObject.SetActive(true);
        this.avatarObjects[this.level].gameObject.SetActive(false);
    }
    protected virtual void ShowRoadPrefab(int currentLevel)
    {
        this.roadPrefabObjects[currentLevel].gameObject.SetActive(true);
        this.roadPrefabObjects[this.level].gameObject.SetActive(false);
    }
    protected virtual void UpdateDistanceLevelUp()
    {
        this.distanceLevelUp += this.distanceChangeMap;
    }
}
