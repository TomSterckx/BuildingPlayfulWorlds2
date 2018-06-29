using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : EnemyMovement {

 public override void Start()
    {
        base.Start();
        base.Update();
    }
public override void Attack()
    {
        
        target.GetComponent<Health>().health  = 0.0f;
        Debug.Log("KIKI");
    }
}
