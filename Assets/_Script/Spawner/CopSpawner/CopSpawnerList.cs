using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CopSpawnerList : LoboMonoBehaviour
{
    [Header("CopSpawner List")]
    [SerializeField] protected int ramdom;
    [SerializeField] protected List<Transform> transforms;

    protected override void LoadComponents()
    {
        this.LoadTransform();
    }

    protected virtual void LoadTransform()
    {
        if (this.transforms.Count > 0) return;

        foreach (Transform transform in transform)
        {
            this.transforms.Add(transform);
            transform.gameObject.SetActive(false);
        }
    }

    protected virtual void OnEnable()
    {
        this.OnEnableRamdomObject();
    }

    protected virtual void OnEnableRamdomObject()
    {
        this.ramdom = Random.Range(0, this.transforms.Count);
        this.OnEnableGameObject(this.ramdom);
    }

    void OnEnableGameObject(int index)
    {
        this.transforms[index].gameObject.SetActive(true);
    }

    protected abstract void PublicTransforms();

}
