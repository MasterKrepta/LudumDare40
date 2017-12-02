using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBuilding : MonoBehaviour {

    public GameObject facility;
    public GameObject ship;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            GameObject newFacility =  Instantiate(facility, transform.position, transform.rotation);
            newFacility.transform.SetParent(ship.transform);
        }
	}
}
