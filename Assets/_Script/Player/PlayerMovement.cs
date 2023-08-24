using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : BaseMovement
{
    [Header("Player Movement")]
    [SerializeField] private Vector2 _velocity = new Vector2(0f, 0f);
    [SerializeField] private float _speedUp = 0.5f;
    [SerializeField] private float _speedDown = 0.5f;
    [SerializeField] private float _speedMax = 20f;
    [SerializeField] private float _speedHorizontal = 6f;
    protected virtual void Update()
    {
        if (InputManager.Instance.PressKeyS) UpdateSpeedDown2();
    }
    private void FixedUpdate()
    {
        this.UpdateSpeed();
        
    }
    protected virtual void UpdateSpeed()
    {
        this._velocity.x = InputManager.Instance.PressHorizontal * this._speedHorizontal;
        
        this.UpdateSpeedUp();
        
        this.UpdateSpeedDown();
        
        this.rb2d.MovePosition(this.rb2d.position + this._velocity * Time.fixedDeltaTime);
    }
    
    protected virtual void UpdateSpeedUp()
    {
        if (InputManager.Instance.PressVertical <= 0) return;
        
        this._velocity.y += this._speedUp;

        if (this._velocity.y > this._speedMax) this._velocity.y = this._speedMax;

        if (transform.position.x < -7 || transform.position.x > 7)
        {
            this._velocity.y -= 1f;
            if (this._velocity.y < 3f) this._velocity.y = 3f;
        }
    }
    protected virtual void UpdateSpeedDown()
    {
        if (InputManager.Instance.PressVertical != 0) return;

        this.UpdateSpeedDown3();
    }
    public virtual void UpdateSpeedDown2()
    {
        if (InputManager.Instance.PressVertical == 0) return;

        this.UpdateSpeedDown3();
    }
    protected virtual void UpdateSpeedDown3()
    {
        this._velocity.y -= this._speedDown;

        if (this._velocity.y < 0) this._velocity.y = 0;

        if (this._velocity.y == 0) this._velocity.x = 0;
    }

    public void DeductSpeedMax(float value)
    {
        this._speedMax -= value;
    }
    
}
