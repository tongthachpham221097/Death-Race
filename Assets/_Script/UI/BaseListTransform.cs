using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseListTransform : LoboMonoBehaviour
{
    protected List<Transform> listTransform;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadListTransform();
        this.PublicListTransform();
    }

    void LoadListTransform()
    {
        if (this.listTransform.Count > 0) return;

        foreach (Transform transform in transform)
        {
            this.listTransform.Add(transform);
        }
    }

    protected abstract void PublicListTransform();

}
