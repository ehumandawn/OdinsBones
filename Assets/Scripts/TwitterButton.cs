using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitterButton : MonoBehaviour {

	public string twitterMsg = "Need the help of a god? Download Odin's Bones!";
	public string twitterDescriptionParam = "";
	private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
	private const string TWITTER_LANGUAGE = "en";

	public string APP_STORE_LINK = "https://play.google.com/store/apps/details?id=com.eHumanDawn.OdinsBones";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick () {
		Application.OpenURL (TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(twitterMsg + "\n" + twitterDescriptionParam + " " + APP_STORE_LINK));
	}


		

}
