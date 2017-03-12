using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using Apex.Serialization;
using System;

public class EvaluateNeedsCaravan : ActionBase {

    public override void Execute(IAIContext context)
    {
        var c = (CaravanContext)context;
        c.needForFood = (c.foodThreshHold / (float) c.food) * c.needForFoodWeight;
        c.needForOil = (c.oilThreshHold / (float) c.oil) * c.needForOilWeight;
        c.needForWater = (c.waterThreshHold / (float) c.water) * c.needForWaterWeight;
    }
	
}
