using System.Collections.Generic;
using Apex.AI.Components;

namespace MyNameSpace1
{

    using System;
    using UnityEngine;
    using Apex.AI;


    public class TargetContextProvider : MonoBehaviour, IContextProvider
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


        private TargetContext _context;

        public void OnEnable()
        {
            _context = new TargetContext(this.transform, _targets, _workedHexInfos, _oil, _wood, _water, _food);
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
        }
    }

}

