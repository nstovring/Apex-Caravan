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
    [Range(0, 10)]
    public int oasisPercentage;
    [Range(0, 10)]
    public int oilPercentage;
    [Range(0, 10)]
    public int fieldPercentage;


    private GameObject terrainGameObject;
    private List<GameObject> objectsSpawned;

    private GameObject terrainHolder;
    public void GenerateTerrain()
    {
        groundPrefab = transform.gameObject;
        if (objectsSpawned != null && objectsSpawned.Count > 0)
        {
            //foreach (var o in objectsSpawned)
            //{
            //    DestroyImmediate(o);
            //}
            //for (int i = 0; i < transform.childCount; i++)
            //{
            //    DestroyImmediate(transform.GetChild(transform.childCount-1).gameObject);
            //}
            DestroyImmediate(terrainHolder);
        }
        
        terrainHolder = new GameObject("Terrain Holder");
        terrainHolder.transform.parent = transform;
        objectsSpawned = new List<GameObject>();
        spawnPoint = transform.position;
        float groundSize =  transform.lossyScale.z/1.75f;
        terrainGameObject = gameObject;
        //terrainGameObject.isStatic = true;
        List<GameObject> enviromentList = WeightedList();
        for (int i = 0; i < prefabAmount; i++)
        {
            Quaternion randomQuaternion = Quaternion.Euler(new Vector3(0, Random.Range(0, 355), 0));
            GameObject prefab = Instantiate(enviromentList[Random.Range(0, enviromentList.Count)],
                new Vector3(Random.Range(spawnPoint.x - groundSize, spawnPoint.x + groundSize),
                    spawnPoint.y + (transform.localScale.y/2)+1f,
                    Random.Range(spawnPoint.z - groundSize, spawnPoint.z + groundSize)), randomQuaternion) as GameObject;
            prefab.transform.localScale *= Random.Range(scaleMin, scaleMax);
            prefab.transform.parent = terrainHolder.transform;
            objectsSpawned.Add(prefab);
            //prefab.isStatic = true;
        }
    }

    public List<GameObject> tempList;

    public List<GameObject> WeightedList()
    {
        tempList = new List<GameObject>();
        int[] weightInts = { treePercentage, rockPercentage/3, rockPercentage/3 ,
            rockPercentage/3 , dunePercentage/2,dunePercentage/2, cactusPercentage, collumnPercentage/2,
            collumnPercentage/2, concretePercentage, oasisPercentage, oilPercentage, fieldPercentage};

        for (int i = 0; i < weightInts.Length; i++)
        {
            for (int j = 0; j < weightInts[i]; j++)
            {
                tempList.Add(enviromentPrefabs[i]);
            }
        }

        return tempList;
    }

    public void EraseTerrain()
    {
            DestroyImmediate(terrainHolder);

        //if (objectsSpawned != null && objectsSpawned.Count > 0)
        //{
        //    foreach (var o in objectsSpawned)
        //    {
        //        DestroyImmediate(o);
        //    }

        //}

        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    DestroyImmediate(transform.GetChild(transform.childCount-1).gameObject);
        //}
    }

}
