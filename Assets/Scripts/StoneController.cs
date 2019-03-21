using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoneController : MonoBehaviour {
	//[SerializeField] private GameObject StonePrefab;
	[SerializeField] private GameObject StonePrefab1;
	[SerializeField] private GameObject StonePrefab2;
	[SerializeField] private GameObject StonePrefab3;
	[SerializeField] private GameObject StonePrefab4;
	[SerializeField] private GameObject StonePrefab5;
	[SerializeField] private GameObject StonePrefab6;
	[SerializeField] private GameObject StonePrefab7;
	[SerializeField] private GameObject StonePrefab8;
	[SerializeField] private GameObject StonePrefab9;
	[SerializeField] private GameObject StonePrefab10;
	[SerializeField] private GameObject StonePrefab11;
	[SerializeField] private GameObject StonePrefab12;
	[SerializeField] private GameObject StonePrefab13;
	[SerializeField] private GameObject StonePrefab14;
	[SerializeField] private GameObject StonePrefab15;
	[SerializeField] private GameObject StonePrefab16;
	[SerializeField] private GameObject StonePrefab17;
	[SerializeField] private GameObject StonePrefab18;
	[SerializeField] private GameObject StonePrefab19;
	[SerializeField] private GameObject StonePrefab20;
	[SerializeField] private GameObject StonePrefab21;
	[SerializeField] private GameObject StonePrefab22;
	[SerializeField] private GameObject StonePrefab23;
	[SerializeField] private GameObject StonePrefab24;
	[SerializeField] private GameObject StonePrefab25;

	// button to read the runes
	//[SerializeField] private GameObject parchment;
	//private GameObject button = null;


	private GameObject[] _stone = new GameObject[6];
	// maximum number of stones I wish to be thrown

	private ArrayList RuneList = new ArrayList ();
	private int count = 0; 


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
		// AND somehow the text that goes with the stones must be printed. 

		while (count < 6) {

			int runeThrown = Random.Range (0, 24);
			Debug.Log ("RuneThrone:" + runeThrown);
		
			if (!RuneList.Contains (runeThrown)) {
				//the rune is new
				RuneList.Add (runeThrown);
				Debug.Log ("Count: " + count);
				if (_stone [count] == null) {
					if (runeThrown == 0) {
						_stone [count] = Instantiate (StonePrefab1) as GameObject;
						_stone [count].transform.position = new Vector3 (runeThrown, 10, -runeThrown);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 1) {
						_stone [count] = Instantiate (StonePrefab2) as GameObject;
						_stone [count].transform.position = new Vector3 (runeThrown, 11, runeThrown);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 2) {
						_stone [count] = Instantiate (StonePrefab3) as GameObject;
						_stone [count].transform.position = new Vector3 (-runeThrown, 12, -13);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 3) {
						_stone [count] = Instantiate (StonePrefab4) as GameObject;
						_stone [count].transform.position = new Vector3 (20, 13, -runeThrown);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 4) {
						_stone [count] = Instantiate (StonePrefab5) as GameObject;
						_stone [count].transform.position = new Vector3 (-runeThrown, 14, -20);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 5) {
						_stone [count] = Instantiate (StonePrefab6) as GameObject;
						_stone [count].transform.position = new Vector3 (-6, 15, -runeThrown);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 6) {
						_stone [count] = Instantiate (StonePrefab7) as GameObject;
						_stone [count].transform.position = new Vector3 (runeThrown, 16, -5);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 7) {
						_stone [count] = Instantiate (StonePrefab8) as GameObject;
						_stone [count].transform.position = new Vector3 (-12, 17, runeThrown);
						_stone [count].transform.Rotate (60, 60, 60);
					} else if (runeThrown == 8) {
						_stone [count] = Instantiate (StonePrefab9) as GameObject;
						_stone [count].transform.position = new Vector3 (-19, 18, 19);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 9) {
						_stone [count] = Instantiate (StonePrefab10) as GameObject;
						_stone [count].transform.position = new Vector3 (-10, 19, -8);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 10) {
						_stone [count] = Instantiate (StonePrefab11) as GameObject;
						_stone [count].transform.position = new Vector3 (-11, 20, -9);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 11) {
						_stone [count] = Instantiate (StonePrefab12) as GameObject;
						_stone [count].transform.position = new Vector3 (-4, 21, 15);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 12) {
						_stone [count] = Instantiate (StonePrefab13) as GameObject;
						_stone [count].transform.position = new Vector3 (5, 22, -runeThrown);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 13) {
						_stone [count] = Instantiate (StonePrefab14) as GameObject;
						_stone [count].transform.position = new Vector3 (-6, 10, -runeThrown);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 14) {
						_stone [count] = Instantiate (StonePrefab15) as GameObject;
						_stone [count].transform.position = new Vector3 (-4, 23, 18);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 15) {
						_stone [count] = Instantiate (StonePrefab16) as GameObject;
						_stone [count].transform.position = new Vector3 (-5, 24, 12);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 16) {
						_stone [count] = Instantiate (StonePrefab17) as GameObject;
						_stone [count].transform.position = new Vector3 (6, 25, -10);
					} else if (runeThrown == 17) {
						_stone [count] = Instantiate (StonePrefab18) as GameObject;
						_stone [count].transform.position = new Vector3 (7, 26, -2);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 18) {
						_stone [count] = Instantiate (StonePrefab19) as GameObject;
						_stone [count].transform.position = new Vector3 (8, 17, -13);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 19) {
						_stone [count] = Instantiate (StonePrefab20) as GameObject;
						_stone [count].transform.position = new Vector3 (9, 28, -2);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 20) {
						_stone [count] = Instantiate (StonePrefab21) as GameObject;
						_stone [count].transform.position = new Vector3 (10, 29, 4);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 21) {
						_stone [count] = Instantiate (StonePrefab22) as GameObject;
						_stone [count].transform.position = new Vector3 (3, 30, 17);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 22) {
						_stone [count] = Instantiate (StonePrefab23) as GameObject;
						_stone [count].transform.position = new Vector3 (-5, 31, -1);
						_stone [count].transform.Rotate (60, 60, 60);

					} else if (runeThrown == 23) {
						_stone [count] = Instantiate (StonePrefab24) as GameObject;
						_stone [count].transform.position = new Vector3 (-9, 32, -3);
						_stone [count].transform.Rotate (60, 0, 60);

					} else if (runeThrown == 24) {
						_stone [count] = Instantiate (StonePrefab25) as GameObject;
						_stone [count].transform.position = new Vector3 (-10, 33, -5);
						_stone [count].transform.Rotate (60, 60, 60);

					}
					count++;  //this should only happen if a new rune is picked
				}

			}
				

		}

		// the stones have been thrown, so wait a bit and then put the ui on screen

		//if (button == null) {
		//	button = Instantiate (parchment) as GameObject;
		//	button.transform.position = new Vector3 (0, 0, 0); //put in center of screen
		//}


	}

	//public void Restart() {
		// we should reload to nothing. Eventually, I need to make text appear on the screen 
		// based on RuneList()

		//SceneManager.LoadScene ("Scene");
	//}



}
