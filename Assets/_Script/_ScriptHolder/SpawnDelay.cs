using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDelay : MonoBehaviour
{
    List<GameObject> minions;
    public GameObject minionPrefab; // Prefab mô tả đối tượng được dựng sẵn trong unity
    public int index = 1;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();
        
        this.CheckMinionDead();
    }

    void Spawn()
    {
        // giải thuật delay
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;
        
        if (this.minions.Count >= 7) return;

        //int index = this.minions.Count + 1;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Bom #" + index;
        index++;
        if (index == 8) index = 1;

        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);//Thay đổi trạng thái của Object sao khi Instantiate 

        this.minions.Add(minion);

    }

    void CheckMinionDead()
    {
        GameObject minion;
        for (int i = 0; i < this.minions.Count; i++)
        {
            minion = this.minions[i];
            if (minion == null) this.minions.RemoveAt(i);
        }
    }

    
}
