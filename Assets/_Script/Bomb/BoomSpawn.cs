using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 12f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }

}
