using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReplayButton : MonoBehaviour {
	[SerializeField] private SettingsPopup settingsPopup;

	// Use this for initialization
	void Start () {
		settingsPopup.Close ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnOpenSettings () {
		settingsPopup.Open ();
	}

	public void OnClick () {
		SceneManager.LoadScene (0);
	}
}
