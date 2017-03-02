using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomer : MonoBehaviour {
    public Vector3 tileZoomInSize = new Vector3(200,0.1f,200);
    public Vector3 tileZoomOutSize = new Vector3(200, 0.1f, 200);

    public Transform LevelZoomedOut;
    public Transform LevelZoomedIn;

    // Use this for initialization
    void Start () {
		
	}

    private bool zoomedIn = false;
	// Update is called once per frame
	void Update ()
	{
	    RaycastHit hit;
	    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	    if (Physics.Raycast(ray, out hit))
	    {
	        if (Input.GetMouseButtonUp(0))
	        {
	            zoomedIn = !zoomedIn;
                Debug.Log("Clicking");
	            if (!zoomedIn)
	            {
                    hit.transform.GetComponent<TerrainGenerator>().Generate();

                    hit.transform.parent = LevelZoomedIn;
                    LevelZoomedOut.gameObject.SetActive(false);

                    StartCoroutine(ZoomIn(hit.transform));
	            }
	            else
	            {
                    hit.transform.parent = LevelZoomedOut;
                    LevelZoomedOut.gameObject.SetActive(true);
                    hit.transform.GetComponent<TerrainGenerator>().Erase();
                    StartCoroutine(ZoomOut(hit.transform));
                }
	        }
	    }
	}

    private Vector3 storedCameraPos;
    private Quaternion storedCameraRot;

    private Vector3 zoomedInCameraPos;
    private Quaternion zoomedInCameraRot;

    IEnumerator ZoomIn(Transform zoomTile)
    {
        storedCameraPos = Camera.main.transform.position;
        storedCameraRot = Camera.main.transform.rotation;

        zoomedInCameraPos = new Vector3(zoomTile.transform.position.x, storedCameraPos.y, zoomTile.transform.position.z);
        zoomedInCameraRot = Quaternion.Euler(70, 0, 0);
        while (Vector3.Distance(zoomTile.transform.localScale, tileZoomInSize) > 0.1f)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, zoomedInCameraPos, 0.01f);
            Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, zoomedInCameraRot,0.01f);
            zoomTile.transform.localScale = Vector3.Lerp(zoomTile.transform.lossyScale, tileZoomInSize, 0.001f);
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator ZoomOut(Transform zoomTile)
    {
       
        while (Vector3.Distance(zoomTile.transform.localScale, tileZoomOutSize) > 0.1f)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, storedCameraPos, 0.01f);
            Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, storedCameraRot, 0.01f);

            zoomTile.transform.localScale = Vector3.Lerp(zoomTile.transform.lossyScale, tileZoomOutSize, 0.001f);
            yield return new WaitForSeconds(0.01f);
        }



    }
}
