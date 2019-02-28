using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour {
	
	[SerializeField] private GameObject StonePrefab;
	private GameObject[] _stone = new GameObject[24];


	// Use this for initialization
	void Start () {
		for (int i = 0; i < _stone.Length; i++) {
			_stone [i] = null;
		}
	}

	// Update is called once per frame
	void Update () {


		for (int i = 0; i < _stone.Length; i++) {
			if (_stone[i] == null) {
				_stone[i] = Instantiate (StonePrefab) as GameObject;
				_stone[i].transform.position = new Vector3 (5, 12, -(25-i));
			}
		
		}

	}

}
