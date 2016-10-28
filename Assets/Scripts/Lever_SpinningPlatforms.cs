using UnityEngine;
using System.Collections;

public class Lever_SpinningPlatforms : Lever {

	public SpinningPlatforms[] spinningPlatforms;

	protected override void UpdateLeverRatio(){
		base.UpdateLeverRatio ();

		float spinSpeedRatio = (leverRatio * 2) - 1;

		for (int i = 0; i < spinningPlatforms.Length; i++) {
			spinningPlatforms [i].SetSpinSpeedRatio (spinSpeedRatio);
		}

	}

	void SetTotalCoins(){
		int totalCoins = 0;

		if (PlayerPrefs.HasKey ("TotalCoins")) {
			totalCoins = PlayerPrefs.GetInt ("TotalCoins");
		}

		totalCoins += PlayerPrefs.GetInt ("Score");

		PlayerPrefs.SetInt ("TotalCoins", totalCoins);
	}
}
