using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : LoboMonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb2d;
    [SerializeField] public Vector2 velocity = new Vector2(0f, 0f);
    [SerializeField] public float speedUp = 0.5f;
    [SerializeField] public float speedDown = 0.5f;
    [SerializeField] public float speedMax = 20f;
    [SerializeField] public float speedHorizontal = 6f;
    
    protected override void LoadComponents()
    {
        this.rb2d = GetComponentInParent<Rigidbody2D>();
    }
    protected virtual void Update()
    {
        if (InputManager.Instance.pressKeyS) UpdateSpeedDown2();
    }
    private void FixedUpdate()
    {
        this.UpdateSpeed();
        
    }
    protected virtual void UpdateSpeed()
    {
        this.velocity.x = InputManager.Instance.pressHorizontal * speedHorizontal;
        
        this.UpdateSpeedUp();
        
        this.UpdateSpeedDown();
        
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }
    
    protected virtual void UpdateSpeedUp()
    {
        if (InputManager.Instance.pressVertical <= 0) return;
        
        this.velocity.y += this.speedUp;

        if (this.velocity.y > this.speedMax) this.velocity.y = this.speedMax;

        if (transform.position.x < -7 || transform.position.x > 7)
        {
            this.velocity.y -= 1f;
            if (this.velocity.y < 3f) this.velocity.y = 3f;
        }
    }
    protected virtual void UpdateSpeedDown()
    {
        if (InputManager.Instance.pressVertical != 0) return;

        this.UpdateSpeedDown3();
    }
    public virtual void UpdateSpeedDown2()
    {
        if (InputManager.Instance.pressVertical == 0) return;

        this.UpdateSpeedDown3();
    }
    protected virtual void UpdateSpeedDown3()
    {
        this.velocity.y -= this.speedDown;

        if (this.velocity.y < 0) this.velocity.y = 0;

        if (this.velocity.y == 0) this.velocity.x = 0;
    }
    
}
