using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIButton : MonoBehaviour {
	[SerializeField] private SettingsPopup settingsPopup;
	[SerializeField] private Text OdinSpeaks;

	private int runeCount = 0;

	private string fortune = "Odin speaks: ";
	
	// Use this for initialization
	void Start () {
		settingsPopup.Close ();
	}

	// Update is called once per frame
	void Update () {

		while (runeCount < StoneController.RuneList.Count) {
			// chose which stone we're on and write the correct phrase into fortune

			if (runeCount == 0) {
				fortune += "\n The overview of the situation is ";
			} else if (runeCount == 1) {
				fortune += "\n Your challenge now is ";
			} else if (runeCount == 2) {
				fortune += "\n The course of action called for is ";
			}

			int i = (int) StoneController.RuneList [runeCount];
			//Debug.Log ("Writing fortune" + i);
			if (i == 0) {
				fortune  += "MANNAZ: Only a clear willingness to change is effective now. ";
			} else if (i == 1) { 
				fortune += "GEBO: Do not lose yourself to another. Allow the winds of Heaven to dance between you. ";
			} else if (i == 2) {
				fortune += "ANSUZ: Even a warning can be seen as a gift. ";
			} else if (i == 3) {
				fortune += "OTHILA: Old skins are shed and outmoded relationships discarded. ";
			} else if (i == 4) {
				fortune += "URUZ: The life you have been living has outgrown its form, cast it off. ";
			} else if (i == 5) {
				fortune += "PERTH: The issue is beyond your powers. ";
			} else if (i == 6) {
				fortune += "NAUTHIZ: Don't take obstacles personally, smile at your teachers instead. ";
			} else if (i == 7) {
				fortune += "INGUZ: You yearn to be desired, to be seen by your beloved. ";
			} else if (i == 8) {
				fortune += "EIHWAZ: You have no influence in the situation. Let it go. ";
			} else if (i == 9) {
				fortune += "ALGIZ: You are protected and this too shall pass. ";
			} else if (i == 10) {
				fortune += "FEHU: Look deeply at what you covet, for there lies your heart. ";
			} else if (i == 11) {
				fortune += "WUNJO: Joy and new energy pours through your life. ";
			} else if (i == 12) {
				fortune += "JERA: Beneficial outcomes are on the horizon but beware, no quick results can be expected. ";
			} else if (i == 13) {
				fortune += "KANO: Mutual understandings are possible. ";
			} else if (i == 14) {
				fortune += "TEIWAZ: For the spiritual warrior, the battle is always with the self. ";
			} else if (i == 15) {
				fortune += "BERKANA: First, disperse resistance, then accomplish the work. ";
			} else if (i == 16) {
				fortune += "EHWAZ: As you cultivate your own nature, all else follows. ";
			} else if (i == 17) {
				fortune += "LAGUZ: Success lies in knowing thyself. ";
			} else if (i == 18) {
				fortune += "HAGALZ: Expect disruption, but do not be dismayed. ";
			} else if (i == 19) {
				fortune += "RAIDO: As the obstructions give way, all remorse arising from trying to make things happen disappears. ";
			} else if (i == 20) {
				fortune += "THURISA: Live on the hilltop between the past and the future. ";
			} else if (i == 21) {
				fortune += "DAGAZ: Sieze the moment for victory is ensured. ";
			} else if (i == 22) {
				fortune += "ISA: You are entangled in a situation in which you are blind. Your plans are on hold. ";
			} else if (i == 23) {
				fortune += "SOWELU: The path is open for work to begin, yet sometimes retreat is the wisest move. ";
			} else if (i == 24) {
				fortune += "ODIN: The blank stone is the beginning and the end. This is the moment where anything can happen. ";
			}
			runeCount++;
		}

		OdinSpeaks.text = String.Copy(fortune);
		//Debug.Log (OdinSpeaks.text);

				
		
	}
		

	public void OnOpenSettings () {
		settingsPopup.Open ();
	}
}
