using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class Accel : ContextualScorerBase
{
    public override float Score(IAIContext context)
    {

        var c = (CaravanContext)context;

        if (c.speed < c.maxSpeed*0.9)
        {
            return this.score;
        }
        return 0;

    }
}
