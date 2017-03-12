using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;

public class TurnLeftScore : ContextualScorerBase {
    public override float Score(IAIContext context)
    {
        var c = (CaravanContext)context;
        Vector3 myDir = Vector3.Normalize( c.self.forward);
        myDir = new Vector3(myDir.x, 0, myDir.z);
        Vector3 cityDir = Vector3.Normalize(c.goal.position - c.self.position);
        cityDir = new Vector3(cityDir.x, 0, cityDir.z);
        if (Vector3.Dot(myDir,cityDir) < 0.95 && !(Vector3.Magnitude(cityDir - myDir) > Mathf.Sqrt(2)))
        {
            return this.score;
        }
        return 0;
    }
}
