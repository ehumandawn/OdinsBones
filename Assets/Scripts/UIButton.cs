using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour {
	[SerializeField] private GameObject targetObject;
	[SerializeField] private string targetMessage;

	public void OnMouseUp() {  //if they click on the message, clear the screen and print fortune
		if (targetObject != null) {
			targetObject.SendMessage (targetMessage);
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
