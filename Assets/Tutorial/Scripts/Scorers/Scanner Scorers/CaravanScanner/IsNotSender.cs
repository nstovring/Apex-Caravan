using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System;

public class IsNotSender : ScannerCustomScorer<CityContextProvider>
{
    public override float Score(IAIContext context, CityContextProvider option)
    {
        var c = (CaravanContext)context;
        if (!option.Equals(c.Sender))
        {
            return this.score;
        }
        return 0;
    }
}
