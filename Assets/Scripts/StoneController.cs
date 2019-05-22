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



	private GameObject[] _stone = new GameObject[4];
	// maximum number of stones I wish to be thrown

    public static ArrayList RuneList = new ArrayList ();
	//private ArrayList Coordinates = new ArrayList ();
	private int count = 0; 


	// Use this for initialization
	void Start () {

		// first initialize prefab array
		for (int i = 0; i < _stone.Length; i++) {
			_stone [i] = null;
		}

		// then clear out RuneList and coordinates in case this is a replay
		RuneList.Clear();
		//Coordinates.Clear();
	}

	// Update is called once per frame
	void Update () {  

		while (count < 4) {

			int runeThrown = Random.Range (0, 25);
			float yLocation = Random.Range (10.0f, 30.0f);
		
			if (!RuneList.Contains (runeThrown)) {
				//the rune is new
				RuneList.Add (runeThrown);
				//Debug.Log ("Count: " + count);
				if (_stone [count] == null) {
					if (runeThrown == 0) {
						_stone [count] = Instantiate (StonePrefab1) as GameObject;
						_stone [count].transform.position = new Vector3 (20, yLocation, -25);
						_stone [count].transform.Rotate (60, 180, 40);
					} else if (runeThrown == 1) {
						_stone [count] = Instantiate (StonePrefab2) as GameObject;
						_stone [count].transform.position = new Vector3 (18, yLocation, -2);
						_stone [count].transform.Rotate (60, 180, 10);
					} else if (runeThrown == 2) {
						_stone [count] = Instantiate (StonePrefab3) as GameObject;
						_stone [count].transform.position = new Vector3 (10, yLocation, -10);
						_stone [count].transform.Rotate (60, 180, -20);
					} else if (runeThrown == 3) {
						_stone [count] = Instantiate (StonePrefab4) as GameObject;
						_stone [count].transform.position = new Vector3 (5, yLocation, -20);
						_stone [count].transform.Rotate (60, 180, 50);
					} else if (runeThrown == 4) {
						_stone [count] = Instantiate (StonePrefab5) as GameObject;
						_stone [count].transform.position = new Vector3 (4, yLocation, -7);
						_stone [count].transform.Rotate (60, 180, 30);
					} else if (runeThrown == 5) {
						_stone [count] = Instantiate (StonePrefab6) as GameObject;
						_stone [count].transform.position = new Vector3 (0, yLocation, -25);
						_stone [count].transform.Rotate (60, 180, 60);
					} else if (runeThrown == 6) {
						_stone [count] = Instantiate (StonePrefab7) as GameObject;
						_stone [count].transform.position = new Vector3 (0, yLocation, 0);
						_stone [count].transform.Rotate (60, 180, -10);
					} else if (runeThrown == 7) {
						_stone [count] = Instantiate (StonePrefab8) as GameObject;
						_stone [count].transform.position = new Vector3 (-5, yLocation, 0);
						_stone [count].transform.Rotate (60, 180, -20);
					} else if (runeThrown == 8) {
						_stone [count] = Instantiate (StonePrefab9) as GameObject;
						_stone [count].transform.position = new Vector3 (-3, yLocation, -5);
						_stone [count].transform.Rotate (60, 180, 30);

					} else if (runeThrown == 9) {
						_stone [count] = Instantiate (StonePrefab10) as GameObject;
						_stone [count].transform.position = new Vector3 (-5, yLocation, -25);
						_stone [count].transform.Rotate (60, 180, -40);

					} else if (runeThrown == 10) {
						_stone [count] = Instantiate (StonePrefab11) as GameObject;
						_stone [count].transform.position = new Vector3 (-15, yLocation, -15);
						_stone [count].transform.Rotate (60, 180, 50);

					} else if (runeThrown == 11) {
						_stone [count] = Instantiate (StonePrefab12) as GameObject;
						_stone [count].transform.position = new Vector3 (-20, yLocation, -30);
						_stone [count].transform.Rotate (60, 180, 60);

					} else if (runeThrown == 12) {
						_stone [count] = Instantiate (StonePrefab13) as GameObject;
						_stone [count].transform.position = new Vector3 (-15, yLocation, -6);
						_stone [count].transform.Rotate (60, 180, -10);

					} else if (runeThrown == 13) {
						_stone [count] = Instantiate (StonePrefab14) as GameObject;
						_stone [count].transform.position = new Vector3 (-15, yLocation, 6);
						_stone [count].transform.Rotate (60, 180, -20);

					} else if (runeThrown == 14) {
						_stone [count] = Instantiate (StonePrefab15) as GameObject;
						_stone [count].transform.position = new Vector3 (-10, yLocation, 10);
						_stone [count].transform.Rotate (60, 180, -30);

					} else if (runeThrown == 15) {
						_stone [count] = Instantiate (StonePrefab16) as GameObject;
						_stone [count].transform.position = new Vector3 (-6, yLocation, 15);
						_stone [count].transform.Rotate (60, 180, -40);

					} else if (runeThrown == 16) {
						_stone [count] = Instantiate (StonePrefab17) as GameObject;
						_stone [count].transform.position = new Vector3 (-10, yLocation, 20);
					} else if (runeThrown == 17) {
						_stone [count] = Instantiate (StonePrefab18) as GameObject;
						_stone [count].transform.position = new Vector3 (-18, yLocation, 25);
						_stone [count].transform.Rotate (60, 180, -50);

					} else if (runeThrown == 18) {
						_stone [count] = Instantiate (StonePrefab19) as GameObject;
						_stone [count].transform.position = new Vector3 (-20, yLocation, 15);
						_stone [count].transform.Rotate (60, 180, -60);

					} else if (runeThrown == 19) {
						_stone [count] = Instantiate (StonePrefab20) as GameObject;
						_stone [count].transform.position = new Vector3 (0, yLocation, 10);
						_stone [count].transform.Rotate (60, 180, 10);

					} else if (runeThrown == 20) {
						_stone [count] = Instantiate (StonePrefab21) as GameObject;
						_stone [count].transform.position = new Vector3 (3, yLocation, 28);
						_stone [count].transform.Rotate (60, 180, 20);

					} else if (runeThrown == 21) {
						_stone [count] = Instantiate (StonePrefab22) as GameObject;
						_stone [count].transform.position = new Vector3 (8, yLocation, 10);
						_stone [count].transform.Rotate (60, 180, 30);

					} else if (runeThrown == 22) {
						_stone [count] = Instantiate (StonePrefab23) as GameObject;
						_stone [count].transform.position = new Vector3 (5, yLocation, 5);
						_stone [count].transform.Rotate (60, 180, 40);

					} else if (runeThrown == 23) {
						_stone [count] = Instantiate (StonePrefab24) as GameObject;
						_stone [count].transform.position = new Vector3 (15, yLocation, 8);
						_stone [count].transform.Rotate (60, 180, 50);

					} else if (runeThrown == 24) {
						_stone [count] = Instantiate (StonePrefab25) as GameObject;
						_stone [count].transform.position = new Vector3 (20, yLocation, 20);
						_stone [count].transform.Rotate (60, 180, 60);

					}
					count++;  //this should only happen if a new rune is picked
				}

			}
				

		}




	}
		

}
