using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.EventSystems;




public class LevelController : MonoBehaviour {
	// this function is used to switch from opening instructions to throwing the runes
	// when deployed to Android, the gyroscope will be the trigger that switches scenes.
	// right now, I'm forcing the switch with a slider.

	Slider slider;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void Awake () {
		slider = GetComponent<Slider> ();
		//if (slider.value == 1) {
			slider.onValueChanged.AddListener (delegate {
				OnSliderWasChanged ();
			});
			OnSliderWasChanged ();
		//}
	}

	public void OnSliderWasChanged() {
		if (slider.value == 1) {
		//Debug.Log ("Not sure why we got here since I haven't touched the sider.");
		SceneManager.LoadScene (1);
		}
	}
}
