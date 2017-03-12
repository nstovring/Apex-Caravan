using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class CaravanTurnAccel : ActionBase
{
    public override void Execute(IAIContext context)
    {
        var c = (CaravanContext)context;
        c.speed += c.maxTurnSpeed * 0.1f;
    }
}
