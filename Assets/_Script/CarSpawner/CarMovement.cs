using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CarMovement : LoboMonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb2d;
    [SerializeField] public Vector2 velocity = new Vector2(0f, 0f);
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigibody();
    }
    protected virtual void LoadRigibody()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }
    protected virtual void FixedUpdate()
    {
        this.velocity.y = 10f;
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }
}
