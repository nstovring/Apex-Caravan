    using System;
    using Apex.AI;
    using Apex.Serialization;
    using MyNameSpace1;
    using UnityEngine;

    public sealed class HasLowOilScorer : ContextualScorerBase
{
        public float score;

        public override float Score(IAIContext _context)
        {
            TargetContext context = (TargetContext) _context;
            //var targets = context._surroundingHexCells;
            return score = 100f/context.oil;

        }
}
