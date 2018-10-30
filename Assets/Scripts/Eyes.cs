using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

    private Camera eyes;
    private float defaultFOV;   
    
	// Use this for initialization
	void Start () {
        eyes = GetComponent<Camera>();
        defaultFOV = eyes.fieldOfView;
	}
}
