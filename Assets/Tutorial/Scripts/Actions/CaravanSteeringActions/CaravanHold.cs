using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;

public class CaravanHold : ActionBase
{
    public override void Execute(IAIContext context)
    {
        var c = (CaravanContext)context;
        c.self.position += Vector3.Normalize(c.self.forward) * c.speed;
        if(Vector3.Magnitude( c.self.position - c.goal.position) < 0.1f)
        {
            c.Sender = c.goal.GetComponent<CityContextProvider>();
        }
    }
}
