using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomer : MonoBehaviour {
    public Vector3 tileZoomInSize = new Vector3(200,1f,200);
    public Vector3 tileZoomOutSize = new Vector3(200, 0.1f, 200);

    public Transform TerrainScalePivot;
    public Transform LevelZoomedIn;

    private Vector3 storedCameraPos;
    private Quaternion storedCameraRot;

    private Vector3 zoomedInCameraPos;
    private Quaternion zoomedInCameraRot;

    private Vector3 storedTilePos;

    private bool zoomedIn = false;
    public Transform zoomedOutChildren;
	// Update is called once per frame


	void Update ()
	{
	    RaycastHit hit;
	    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        TerrainScalePivot.localScale += Vector3.one *Input.GetAxis("Mouse ScrollWheel") * TerrainScalePivot.localScale.z;

        transform.position += new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
	    if (Physics.Raycast(ray, out hit))
	    {
	        if (hit.transform)
	        {
	            zoomedOutChildren.parent = null;
	            TerrainScalePivot.transform.position = hit.transform.position;
	            zoomedOutChildren.parent = TerrainScalePivot;
	        }
	        if (Input.GetMouseButtonUp(0))
	        {
	            zoomedIn = !zoomedIn;
                Debug.Log("Clicking");
	            if (!zoomedIn)
	            {
                    //hit.transform.GetComponent<TerrainGenerator>().Generate();

                    //hit.transform.parent = LevelZoomedIn;
                    //LevelZoomedOut.gameObject.SetActive(false);

                    //StartCoroutine(ZoomIn(hit.transform));
	            }
	            else
	            {
                    //hit.transform.parent = LevelZoomedOut;
                    //LevelZoomedOut.gameObject.SetActive(true);
                    //hit.transform.GetComponent<TerrainGenerator>().Erase();
                    //StartCoroutine(ZoomOut(hit.transform));
                }
	        }
	    }
	}


}
