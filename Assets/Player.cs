using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private void Update()
    {
        Move(Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public override void Attack(Enemy target)
    {
        base.Attack(target);
    }
}
