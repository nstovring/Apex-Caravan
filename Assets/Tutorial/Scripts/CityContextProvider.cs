using System.Collections.Generic;
using Apex.AI.Components;


    using System;
    using UnityEngine;
    using Apex.AI;


    public class CityContextProvider : MonoBehaviour, IContextProvider
    {
        [SerializeField] private List<HexInfo> _targets;
        [SerializeField]
        private List<HexInfo> _workedHexInfos;

        [SerializeField]
        public int _oil = 10;
        [SerializeField]
        private int _wood = 10;
        [SerializeField]
        private int _water = 10;
        [SerializeField]
        private int _food = 10;
    [SerializeField]
    private int _growThreshhold = 20;
    [SerializeField]
    public int _oilBasePrice = 10;
    [SerializeField]
    private int _waterBasePrice = 10;
    [SerializeField]
    private int _foodBasePrice = 10;
    [SerializeField]
    public float _oilPrice = 10;
    [SerializeField]
    private float _waterPrice = 10;
    [SerializeField]
    private float _foodPrice = 10;

    public CityContext _context;

        public void OnEnable()
        {
            _context = new CityContext(this.transform, _targets, _workedHexInfos, _oil + UnityEngine.Random.Range(0, 4), _wood , _water + UnityEngine.Random.Range(0, 4), _food + UnityEngine.Random.Range(0, 4));
        _context.oilBasePrice = _oilBasePrice;
        _context.waterBasePrice = _waterBasePrice;
        _context.foodBasePrice = _foodBasePrice;
        }

        public IAIContext GetContext(Guid aiId)
        {
            return _context;
        }


        void Update()
        {
            _oil = _context.oil;
            _water = _context.water;
            _food = _context.food;
        _context.GrowThreshhold = _growThreshhold;
            UpdateUI();
        _oilPrice = _context.oilPrice;
        _foodPrice = _context.foodPrice;
        _waterPrice = _context.waterPrice;
        
        }

        public TextMesh resourceDisplayTextMesh;
        void UpdateUI()
        {
            resourceDisplayTextMesh.text = "Oil: " + _oil + "\n Water: " + _water + "\n Food: " + _food;
        }
    }



