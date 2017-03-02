using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    public List<GameObject> terrainObjects;
    public GameObject cube;
	// Use this for initialization
	public void Generate ()
	{
        terrainObjects = new List<GameObject>();
	    float scale = transform.lossyScale.z;
	    int scaledScale = (int) (scale/16f);

        for (int i = 0; i < 8; i++)
	    {

            for (int j = 0; j < 8; j++)
	        {
	            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.parent = transform;
	            go.transform.localPosition= Vector3.zero;
                go.transform.localPosition += new Vector3(Random.Range(-scale/2,scale/2), transform.localPosition.y, Random.Range(-scale/2, scale/2));
                terrainObjects.Add(go);
                go.transform.localScale = new Vector3(Random.Range(0.01f, 0.1f) * scale, Random.Range(0.1f, 43f) * scale, Random.Range(0.01f, 0.1f) * scale);
            }
        }
	}

    public void Erase()
    {
        foreach (var terrainObject in terrainObjects)
        {
            Destroy(terrainObject,1);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
