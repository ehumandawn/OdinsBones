using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Accelerometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 shake = Input.acceleration;

		if (shake.sqrMagnitude > 3.0) {
			//FadeToScene (1);
		}
	}
}
