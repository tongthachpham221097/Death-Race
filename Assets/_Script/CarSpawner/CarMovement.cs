using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CarMovement : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb2d;
    [SerializeField] public Vector2 velocity = new Vector2(0f, 0f);
    protected virtual void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }
    protected virtual void FixedUpdate()
    {
        this.velocity.y = 10f;
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }
}
