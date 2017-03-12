using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class Decel : ContextualScorerBase
{
    public override float Score(IAIContext context)
    {

        var c = (CaravanContext)context;

        if (c.speed > c.maxSpeed * 0.95)
        {
            return this.score;
        }
        return 0;

    }
}
