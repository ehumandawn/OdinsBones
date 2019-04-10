using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Accelerometer : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 shake = Input.acceleration;

		if (shake.sqrMagnitude > 3.0) {
			SceneManager.LoadScene (1);
		}
	}
}
