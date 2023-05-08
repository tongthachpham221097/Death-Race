using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{  
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ModelCar") Time.timeScale = 0;
    }
}
