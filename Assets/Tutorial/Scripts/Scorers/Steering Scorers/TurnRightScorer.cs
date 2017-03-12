using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class TurnRightScore : ContextualScorerBase
{
    public override float Score(IAIContext context)
    {
        var c = (CaravanContext)context;
        Vector3 myDir = Vector3.Normalize(c.self.forward);
        Vector3 cityDir = Vector3.Normalize(c.goal.position - c.self.position);
        if (Vector3.Dot(myDir, cityDir) < 0.95)
        {
            return this.score;
        }
        return 0;
    }
}
