using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class CaravanAccel : ActionBase
{
    public override void Execute(IAIContext context)
    {
        var c = (CaravanContext)context;
        c.speed += c.maxSpeed * 0.1f;
    }
}
