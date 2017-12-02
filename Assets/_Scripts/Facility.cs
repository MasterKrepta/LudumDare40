using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facility : MonoBehaviour {

    public enum FacilityType { FARM, VR, SECURITY, CELLS, FACTORY }

    [SerializeField]
    private FacilityType type;
    [SerializeField]
    private float foodProduction = 0;
    [SerializeField]
    private float funProduction = 0;
    

    #region Getters
    public float FoodProduction { get; set; }
    public float FunProduction { get; set; }

    #endregion

    // Use this for initialization
    void Start () {
        InitializeFacility();
	}
	
    void InitializeFacility() {
        type = FacilityType.VR;
        if (type == FacilityType.FARM) {
            foodProduction++;
        }
        else {
            funProduction++;
        }
        

    } 
	// Update is called once per frame
	void Update () {
		
	}
}
