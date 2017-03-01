using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System.Linq;
public sealed class ExpendResources : ActionBase {


    public override void Execute(IAIContext context)
    {
        var c = (TargetContext) context;
        c.oil--;
        c.food--;
        c.water--;
        // List<HexInfo> h = new List<HexInfo>(c._surroundingHexCells.OrderBy(x => x.oil));
        //c._workedHexCells.Add(h[h.Count-1]);
        //Debug.Log("Moved Worker "  + h[h.Count - 1].oil);
    }
}
