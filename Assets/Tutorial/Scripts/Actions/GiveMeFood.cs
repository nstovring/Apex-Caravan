namespace MyNameSpace1
{
    using Apex.AI;
    using UnityEngine;

    public class GiveMeFood : ActionWithOptions<GameObject>
    {

        public override void Execute(IAIContext c)
        {
            var context = (TargetContext)c;

            context.food += 5;

            context.wood -= (int)Random.Range(1, 3);
            context.water -= (int)Random.Range(1, 3);
            context.oil -= (int)Random.Range(1, 3);
        }

    }
}