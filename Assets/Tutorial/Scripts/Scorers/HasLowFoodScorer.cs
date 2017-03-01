
using System;
using Apex.AI;
using Apex.Serialization;
using UnityEngine;

public sealed class HasLowFoodScorer : ContextualScorerBase
{
    public override float Score(IAIContext _context)
    {
        TargetContext context = (TargetContext)_context;
        score = (100f / context.food);
        //Debug.Log(score + " Food");
        //var targets = context._surroundingHexCells;
        return this.score;
    }
}

