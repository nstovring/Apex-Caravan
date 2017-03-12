using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;

public class TurnAccel : ContextualScorerBase {
    public override float Score(IAIContext context)
    {

        var c = (CaravanContext)context;

        if(c.speed < c.maxTurnSpeed * 0.7)
        {
            return this.score;
        }
        return 0;

    }

}
