using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class Accel : ContextualScorerBase
{
    public override float Score(IAIContext context)
    {

        var c = (CaravanContext)context;

        //c.speed = Mathf.Clamp(c.speed, (c.speed + score)*Time.deltaTime, c.maxSpeed);

        if (c.speed < c.maxSpeed*0.5)
        {
            return this.score;
        }
        return 0;

    }
}
