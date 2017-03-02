using System.Collections.Generic;
using Apex.AI;
using UnityEngine;

public sealed class CaravanContext : IAIContext
{

   

    public CaravanContext(Transform transform, List<GameObject> gameObjectsList)
    {
        this.self = transform;
        KnownCities = gameObjectsList;
    }

    public Transform self { get; private set; }
    public List<GameObject> KnownCities {get; private set; }

    
}
