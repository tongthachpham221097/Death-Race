using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public abstract class BaseListTransform : LoboMonoBehaviour
{
    protected List<Transform> listTransform = new List<Transform>();

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

    public void OnEnableAllGameObject()
    {
        for (int i = 0; i < this.listTransform.Count; i++)
        {
            this.OnEnableGameObject(i);
        }
    }

    public void OnEnableSomeGameObject(int index)
    {
        for(int i = 0; i < this.listTransform.Count; i++)
        {
            if (i == index) continue;
            this.OnEnableGameObject(i);
        }
    }

    public void DisableSomeGameObject(int index)
    {
        for (int i = 0; i < this.listTransform.Count; i++)
        {
            if (i == index) continue;
            this.DisableGameObject(i);
        }
    }

    public void DisableAllGameObject()
    {
        for (int i = 0; i < this.listTransform.Count; i++)
        {
            this.DisableGameObject(i);
        }
    }

    public void OnEnableGameObject(int index)
    {
        if (this.listTransform[index].gameObject.activeSelf) return;
        this.listTransform[index].gameObject.SetActive(true);
    }

    public void DisableGameObject(int index)
    {
        if (!this.listTransform[index].gameObject.activeSelf) return;
        this.listTransform[index].gameObject.SetActive(false);
    }

}
