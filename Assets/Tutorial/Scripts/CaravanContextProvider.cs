using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI.Components;
using Apex.AI;
using System;

public class CaravanContextProvider : MonoBehaviour, IContextProvider {

    public CityContextProvider _sender;
    public CaravanContext _context;
    [SerializeField]
    public int _oil = 10;
    [SerializeField]
    private int _water = 10;
    [SerializeField]
    private int _food = 10;
    [SerializeField]
    public List<CityContextProvider> _cities;
    private List<CityContext> _cityContexts = new List<CityContext>();
    public float needForWater;
    public float needForFood;
    public float needForOil;
    [SerializeField]
    public int waterThreshHold = 10;
    [SerializeField]
    public int foodThreshHold = 10;
    [SerializeField]
    public int oilThreshHold = 10;
    [SerializeField]
    public int needForWaterWeight = 1;
    [SerializeField]
    public int needForFoodWeight = 1;
    [SerializeField]
    public int needForOilWeight = 1;
    public float _maxSpeed = 10;
    public float _maxTurnSpeed = 5;
    public void OnEnable()
    {
        _context = new CaravanContext(transform, _oil + UnityEngine.Random.Range(0, 4), _water + UnityEngine.Random.Range(0, 4), _food + UnityEngine.Random.Range(0, 4), _cities);
        _context.Sender = _sender;
        _context.maxSpeed = _maxSpeed;
        _context.maxTurnSpeed = _maxTurnSpeed;
    }
    public IAIContext GetContext(Guid aiId)
    {
        return _context;
    }
    public void Update()
    {
        _context.needForFoodWeight = needForFoodWeight;
        _context.needForOilWeight = needForOilWeight;
        _context.needForWaterWeight = needForWaterWeight;
        _context.foodThreshHold = foodThreshHold;
        _context.waterThreshHold = waterThreshHold;
        _context.oilThreshHold = oilThreshHold;
        _oil = _context.oil;
        _water = _context.water;
        _food = _context.food;
        needForFood = _context.needForFood;
        needForWater = _context.needForWater;
        needForOil = _context.needForOil;
    }
}
