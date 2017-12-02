using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    [SerializeField]
    private float appatite = 1;
    [SerializeField]
    private float fun = 1;
    [SerializeField]
    private float trouble = 1;
    [SerializeField]
    private float workEthic = 1;

    #region Getters
    public float Appatite { get; set; }
    public float Fun { get; set; }
    public float Trouble { get; set; }
    public float WorkEthic { get; set; }
    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
