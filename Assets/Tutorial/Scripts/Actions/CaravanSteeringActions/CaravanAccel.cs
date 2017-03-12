using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class CaravanAccel : ActionBase
{
    public override void Execute(IAIContext context)
    {
        var c = (CaravanContext)context;
        c.speed = Mathf.Clamp(c.speed, c.speed + (c.maxSpeed * 0.01f), c.maxSpeed);

        //c.speed += c.maxSpeed * 0.1f;
    }
}
