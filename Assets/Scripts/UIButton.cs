using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIButton : MonoBehaviour {
	[SerializeField] private SettingsPopup settingsPopup;
	[SerializeField] private Text OdinSpeaks;

	private int runeCount = 0;

	private string fortune = "Odin Speaks: ";
	
	// Use this for initialization
	void Start () {
		OdinSpeaks.text = "This is the beginning and should go away.";
		settingsPopup.Close ();
	}

	// Update is called once per frame
	void Update () {

		while (runeCount < StoneController.RuneList.Count) {
			int i = (int) StoneController.RuneList [runeCount];
			Debug.Log ("Writing fortune" + i);
			if (i == 0) {
				fortune  += "Only a clear willingness to change is effective now. ";
			} else if (i == 1) { 
				fortune += "Do not lose yourself to another. Allow the winds of Heaven to dance between you. ";
			} else if (i == 2) {
				fortune += "Even a warning can be seen as a gift. ";
			} else if (i == 3) {
				fortune += "Old skins are shed and outmoded relationships discarded. ";
			} else if (i == 4) {
				fortune += "The life you have been living has outgrown its form, cast it off. ";
			} else if (i == 5) {
				fortune += "The issue is beyond your powers. ";
			} else if (i == 6) {
				fortune += "Don't take obstacles personally, smile at your teachers instead. ";
			} else if (i == 7) {
				fortune += "You yearn to be desired, to be seen by your beloved. ";
			} else if (i == 8) {
				fortune += "You have no influence in the situation. Let it go. ";
			} else if (i == 9) {
				fortune += "You are protected and this too shall pass. ";
			} else if (i == 10) {
				fortune += "Look deeply at what you covet, for there lies your heart. ";
			} else if (i == 11) {
				fortune += "Joy and new energy pours through your life. ";
			} else if (i == 12) {
				fortune += "Beneficial outcomes are on the horizon but beware, no quick results can be expected. ";
			} else if (i == 13) {
				fortune += "Mutual understandings are possible. ";
			} else if (i == 14) {
				fortune += "For the spiritual warrior, the battle is always with the self. ";
			} else if (i == 15) {
				fortune += "First, disperse resistance, then accomplish the work. ";
			} else if (i == 16) {
				fortune += "As you cultivate your own nature, all else follows. ";
			} else if (i == 17) {
				fortune += "Success lies in knowing thyself. ";
			} else if (i == 18) {
				fortune += "Expect disruption, but do not be dismayed. ";
			} else if (i == 19) {
				fortune += "All are united in one mind. ";
			} else if (i == 20) {
				fortune += "Live on the hilltop between the past and the future. ";
			} else if (i == 21) {
				fortune += "Sieze the moment for victory is ensured. ";
			} else if (i == 22) {
				fortune += "You are entangled in a situation in which you are blind. Your plans are on hold. ";
			} else if (i == 23) {
				fortune += "The path is open for work to begin, yet sometimes retreat is the wisest move. ";
			} else if (i == 24) {
				fortune += "This is the moment where anything can happen. ";
			}
			runeCount++;
		}

		OdinSpeaks.text = String.Copy(fortune);
		Debug.Log (OdinSpeaks.text);

				
		
	}

	public void OnOpenSettings () {
		settingsPopup.Open ();
	}
}
