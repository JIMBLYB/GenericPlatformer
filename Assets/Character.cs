using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    protected int health;
    [SerializeField]
    protected int damage;
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected float jumpHeight;

    [SerializeField]
    private Rigidbody2D rb2d;

    protected void Death()
    {
        Destroy(gameObject);
    }

    public virtual void Move(float moveAmount)
    {
        rb2d.velocity = new Vector2(moveAmount * speed, rb2d.velocity.y);
    }

    public virtual void Jump()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y + jumpHeight);
    }

    public virtual void Attack(Enemy target)
    {
        target.health -= damage;
        if (target.health <= 0)
        {
            target.Death();
        }
    }
}    
