using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
[ExecuteInEditMode]
public class TerrainGenerator : MonoBehaviour
{

    public Vector3 spawnPoint;
    public GameObject groundPrefab;
    public GameObject[] enviromentPrefabs;
    public int prefabAmount;
    public float scaleMax;
    public float scaleMin;
    [Range(0,10)]
    public int treePercentage;
    [Range(0, 10)]
    public int rockPercentage;
    [Range(0, 10)]
    public int dunePercentage;
    [Range(0, 10)]
    public int cactusPercentage;
    [Range(0, 10)]
    public int collumnPercentage;
    [Range(0, 10)]
    public int concretePercentage;

    private GameObject terrainGameObject;
    private List<GameObject> objectsSpawned;
    public void GenerateTerrain()
    {
        if (objectsSpawned != null && objectsSpawned.Count > 0)
        {
            foreach (var o in objectsSpawned)
            {
                DestroyImmediate(o);
            }
        }
      
        objectsSpawned = new List<GameObject>();
        spawnPoint = transform.position;
        float groundSize =  transform.localScale.z/2;
        terrainGameObject = gameObject;
        terrainGameObject.isStatic = true;
        List<GameObject> enviromentList = WeightedList();
        for (int i = 0; i < prefabAmount; i++)
        {
            Quaternion randomQuaternion = Quaternion.Euler(new Vector3(0, Random.Range(0, 355), 0));
            GameObject prefab = Instantiate(enviromentList[Random.Range(0, enviromentList.Count)],
                new Vector3(Random.Range(spawnPoint.x - groundSize, spawnPoint.x + groundSize),
                    spawnPoint.y,
                    Random.Range(spawnPoint.z - groundSize, spawnPoint.z + groundSize)), randomQuaternion) as GameObject;
            prefab.transform.localScale *= Random.Range(scaleMin, scaleMax)/1000;
            prefab.transform.parent = terrainGameObject.transform;
            objectsSpawned.Add(prefab);
            prefab.isStatic = true;
        }
    }

    public List<GameObject> WeightedList()
    {
        List<GameObject> tempList = new List<GameObject>();

        int[] weightInts = { treePercentage, treePercentage, rockPercentage, rockPercentage ,
            rockPercentage , dunePercentage, dunePercentage, cactusPercentage, collumnPercentage,
            collumnPercentage, concretePercentage};

        for (int i = 0; i < weightInts.Length; i++)
        {
            for (int j = 0; j < weightInts[i]; j++)
            {
                tempList.Add(enviromentPrefabs[i]);
            }
        }

        return tempList;
    }
}
