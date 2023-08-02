using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageMenuItemBtn : BaseButton
{
    [SerializeField] protected GarageMenuItem garageMenuItem;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGarageMenuItem();
    }

    void LoadGarageMenuItem()
    {
        if (this.garageMenuItem != null) return;
        this.garageMenuItem = GetComponentInParent<GarageMenuItem>();
        Debug.Log(transform.name + ": LoadGarageMenuItem", gameObject);
    }

    protected override void OnClick()
    {
        transform.gameObject.SetActive(false);
    }
}
