using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : LoboMonoBehaviour
{
    [SerializeField] protected EnemyCtrl enemyCtrl;
    public EnemyCtrl EnemyCtrl { get => enemyCtrl; }

    public float speed = 27f;
    public float disLimit = 6f;
    public float randPos = 0;

    protected override void Awake()
    {
        this.randPos = Random.Range(-6, 6);
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }
    protected virtual void LoadEnemyCtrl()
    {
        if (this.enemyCtrl != null) return;
        this.enemyCtrl = GetComponentInParent<EnemyCtrl>();
        Debug.Log(transform.name + ": LoadEnemyCtrl", gameObject);
    }
    private void FixedUpdate()
    {
        this.Follow();
    }
    protected virtual void Follow()
    {
        Vector3 pos = this.enemyCtrl.PlayerCtrl.transform.position;
        pos.x = this.randPos;
        Vector3 distance = pos - transform.position;
        if(distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}
