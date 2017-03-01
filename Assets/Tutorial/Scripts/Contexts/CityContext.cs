using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
public class CityContext : IAIContext {

    public float food;
    public float water;
    public float oil;

    public List<HexInfo> _surroundingHexCells;
    public List<HexInfo> _workedHexCells;

    //public int tilesBeingWorked;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
