using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

	private float minVelocity = 25.0f;
	private Rigidbody body;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name != "Table")  {
			body = GetComponent<Rigidbody> ();
			//body.transform.Rotate (90, 0, 90);
			Deflection (collision.contacts [0].normal);
		}
	}

	private void Deflection (Vector3 collisionNormal) {
		var speed = body.velocity.magnitude;
		var direction = Vector3.Reflect(body.velocity.normalized, collisionNormal);
		body.velocity = direction * Mathf.Max(speed, minVelocity);
	}


	// Update is called once per frame
	void Update () {
		
	}
}
