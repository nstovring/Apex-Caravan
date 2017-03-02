﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMapEditor : MonoBehaviour {

    public Color[] colors;

    public HexGrid hexGrid;

    private Color activeColor;

    void Awake()
    {
        SelectColor(0);
    }

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
        //    HandleInput();


        }
    }

    void HandleInput()
    {
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(inputRay, out hit))
        {
            hexGrid.ColorCell(hit.point, activeColor);
        }

    }

    public void SelectColor(int index)
    {
        activeColor = colors[index];
    }
}
