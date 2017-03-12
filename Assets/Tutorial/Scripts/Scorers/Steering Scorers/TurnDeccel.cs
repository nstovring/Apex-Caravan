using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class TurnDeccel : ContextualScorerBase
{
    public override float Score(IAIContext context)
    {

        var c = (CaravanContext)context;

        if (c.speed > c.maxTurnSpeed)
        {
            return this.score;
        }
        return 0;

    }
}
