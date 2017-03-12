using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TerrainGenerator))]
public class HexInfo : MonoBehaviour
{
    public int oil;
    public int food, water;

    public bool isBeingWorkedOn;

    public Renderer myRenderer;
    public TerrainGenerator myGenerator;
    // Use this for initialization
    void Start()
    {
        int rand = Random.Range(0, 3);
        myRenderer = GetComponent<Renderer>();
        myGenerator = GetComponent<TerrainGenerator>();
        switch (rand)
        {
            case 0:
                oil = Random.Range(3, 8);
                break;
            case 1:
                food = Random.Range(3, 8);
                break;
            case 2:
                water = Random.Range(3, 8);
                return;
        }
        //if (myGenerator != null)
        //{
            myGenerator.oasisPercentage = water;
            myGenerator.oilPercentage = oil;
            myGenerator.fieldPercentage = food;

            myGenerator.GenerateTerrain();
        //}

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
