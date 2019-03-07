using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour {
	//[SerializeField] private GameObject StonePrefab;
	[SerializeField] private GameObject StonePrefab1;
	[SerializeField] private GameObject StonePrefab2;

	private GameObject[] _stone = new GameObject[24];


	// Use this for initialization
	void Start () {
		for (int i = 0; i < _stone.Length; i++) {
			_stone [i] = null;
		}
	}

	// Update is called once per frame
	void Update () {
		// this needs to have code to instantiate 24 different rocks with runes on each one
		// AND it needs to know which stones have stopped moving, those are the ones that are read
		// AND those stones must fall face up in the box
		// AND be random, not the same stones should land in the box each time
		// AND somehow the text that goes with the stones must be printed. An ArrayList of 24 different stones perhaps?

		for (int i = 0; i < _stone.Length; i++) {
			if (_stone[i] == null) {
				//_stone [i] = Instantiate (StonePrefab) as GameObject;
				//_stone [i].transform.position = new Vector3 (i, 4, -i);

				if (i % 2 == 0) {
					_stone [i] = Instantiate (StonePrefab1) as GameObject;
					_stone [i].transform.position = new Vector3 (i, 4, -i);
				} else {
					_stone [i] = Instantiate (StonePrefab2) as GameObject;
					_stone [i].transform.position = new Vector3 (i, 4, -i);
				}

			}
		
		}

	}

}
