using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanMover : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    cProvider = GetComponent<CaravanContextProvider>();
	}

    private CaravanContextProvider cProvider;
    // Update is called once per frame
    private float speed = 0;
    private float MaxSpeed = 0.01f;

    void FixedUpdate () {

	    if (cProvider._currentGoal)
	    {
	        Vector3 cityDir = cProvider._currentGoal.position - transform.position;
	        cityDir.y = 0;
            speed = Mathf.Clamp(speed, speed + ((MaxSpeed * 0.1f)), MaxSpeed);
            Quaternion rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(cityDir),0.1f);

	        transform.position += transform.forward*speed * Time.deltaTime;
	        transform.rotation = rotation;
	    }
    }
}
