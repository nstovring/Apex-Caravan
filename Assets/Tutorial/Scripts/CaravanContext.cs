using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;

public class CaravanContext : IAIContext {
    public Transform self { get; private set; }
    public int oil;
    public int water;
    public int food;
    public List<CityContextProvider> cities;
    public CityContextProvider Sender;
    public float needForWater;
    public float needForFood;
    public float needForOil;
    public int waterThreshHold;
    public int foodThreshHold;
    public int oilThreshHold;
    public float needForWaterWeight;
    public float needForFoodWeight;
    public float needForOilWeight;
    public Transform goal;
    public float speed = 0;
    public float maxTurnSpeed;
    public float maxSpeed;
    //public List<CityContext> cities = new List<CityContext>();

    public CaravanContext(Transform transform, int oil, int water, int food, List<CityContextProvider> cities)
    {
        this.self = transform;
        this.oil = oil;
        this.water = water;
        this.food = food;
        this.cities = cities;
        
    }
}
