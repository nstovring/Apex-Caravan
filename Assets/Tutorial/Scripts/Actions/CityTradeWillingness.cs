using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using Apex.Serialization;
using System;

public class CityTradeWillingness : ActionBase
{
    public override void Execute(IAIContext context)
    {
        var c = (CityContext)context;
        c.foodTradeWilling = (float)c.food / (float)c.GrowThreshhold;
        c.oilTradeWilling = (float)c.oil / (float)c.GrowThreshhold;
        c.waterTradeWilling = (float)c.water / (float)c.GrowThreshhold;
        if (c.oilTradeWilling > 1f) c.oilPrice = c.oilBasePrice /c.oilTradeWilling;
        else c.oilPrice = 1000000000;
        if (c.foodTradeWilling > 1f) c.foodPrice = c.foodBasePrice/c.foodTradeWilling;
        else c.foodPrice = 1000000000;
        if (c.waterTradeWilling > 1f) c.waterPrice = c.waterBasePrice/c.waterTradeWilling;
        else c.waterPrice = 1000000000;

    }
}
