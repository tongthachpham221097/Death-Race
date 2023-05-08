using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CSPMovement : PlayerMovement
{
    protected override void UpdateSpeed()
    {
        this.UpdateSpeedUp();

        this.UpdateSpeedDown();
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }
    
}
