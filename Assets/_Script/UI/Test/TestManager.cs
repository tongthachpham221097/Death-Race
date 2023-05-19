using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{
    //[SerializeField] protected int score;
    [Header("Score Manager")]

    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider { get => playerCollider; }
    protected virtual void Reset()
    {
        this.LoadPlayerCollider();
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = FindAnyObjectByType<PlayerCollider>();
        Debug.Log(transform.name + ": LoadPlayerCollider", gameObject);
    }
    
    
    protected virtual void CalScore()
    {
        // to do with car spawn front player
        // score with enemy 
    }
}
