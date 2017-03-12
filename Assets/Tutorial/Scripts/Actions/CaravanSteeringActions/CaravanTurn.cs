using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class CaravanTurn : ActionBase
{
    public override void Execute(IAIContext context)
    {
        var c = (CaravanContext)context;
        Vector3 myDir = Vector3.Normalize(c.self.forward);
        myDir = new Vector3(myDir.x, 0, myDir.z);
        Vector3 cityDir = Vector3.Normalize(c.goal.position - c.self.position);
        cityDir = new Vector3(cityDir.x, 0, cityDir.z);
        if(Vector3.Magnitude(cityDir - myDir) == 2f)
        {
            myDir += new Vector3(0.1f, 0, 0.1f);
            myDir = Vector3.Normalize(myDir);
        }
        c.self.forward += Vector3.Normalize(cityDir - myDir) * 0.1f;
        c.self.forward = Vector3.Normalize(c.self.forward);
    }
}
