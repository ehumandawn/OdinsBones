using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fading : MonoBehaviour {
	public Animator animator;
	private int SceneToLoad;
  	

	void Update () {

		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("OpeningScene")) { 
			// I only want to do this if we're in the opening scene
			Vector3 shake = Input.acceleration;

			if (shake.sqrMagnitude > 3.0) {
				FadeToScene (1);
			}
		}
	}

	public void FadeToScene (int sceneIndex) {
		SceneToLoad = sceneIndex;
		animator.SetTrigger ("Fadeout");
	}

	public void OnFadeComplete() {
		SceneManager.LoadScene (SceneToLoad);
	}

}
