using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : LoboMonoBehaviour
{
    [Header("Base Movement")]
    [SerializeField] protected Rigidbody2D rb2d;
    protected override void LoadComponents()
    {
        this.rb2d = GetComponentInParent<Rigidbody2D>();
    }
}
