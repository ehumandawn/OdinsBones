using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

	public AudioSource StoneSound;

	// Use this for initialization
	void Start () {
		StoneSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		StoneSound.Play ();
	}
}
