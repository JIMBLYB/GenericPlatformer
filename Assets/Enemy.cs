using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    private void Update()
    {
        Move(1);
    }

    public override void Jump()
    {
        base.Jump();
    }

    public override void Attack(Enemy target)
    {
        base.Attack(target);
    }
}
