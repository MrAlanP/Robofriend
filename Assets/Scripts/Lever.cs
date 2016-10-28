using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using VRTK;

public class Lever : MonoBehaviour {

	public VRTK.VRTK_Lever lever;
	public bool allowMultipleUses = false;
	public UnityEvent OnLeverDown, OnLeverUp;

	float startAngle = 0;
	float leverAngleRange = 0;
	protected float leverRatio = 0;

	bool hasDownActivated = false;
	bool hasUpActivated = false;
	// Use this for initialization
	void Start () {
		switch (lever.direction) {
		case VRTK_Lever.LeverDirection.x:
			startAngle = transform.localEulerAngles.x;
			break;
		case VRTK_Lever.LeverDirection.y:
			startAngle = transform.localEulerAngles.y;
			break;
		case VRTK_Lever.LeverDirection.z:
			startAngle = transform.localEulerAngles.z;
			break;
		}

		leverAngleRange = lever.maxAngle - lever.minAngle;

		UpdateLeverRatio ();

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnValueChanged(){
		UpdateLeverRatio ();
	}

	protected virtual void UpdateLeverRatio(){
		float leverAngle = 0;
		switch (lever.direction) {
		case VRTK_Lever.LeverDirection.x:
			leverAngle = transform.localEulerAngles.x;
			break;
		case VRTK_Lever.LeverDirection.y:
			leverAngle = transform.localEulerAngles.y;
			break;
		case VRTK_Lever.LeverDirection.z:
			leverAngle = transform.localEulerAngles.z;
			break;
		}
		leverAngle -= startAngle;
		leverAngle = (leverAngle > 180) ? leverAngle - 360 : leverAngle;

		float leverAngleFromMin = leverAngle - lever.minAngle;
		float ratio = leverAngleFromMin / leverAngleRange;

		if (ratio < 0.075f && leverRatio > 0.075f) {
			if (OnLeverDown != null && (allowMultipleUses || !hasDownActivated)) {
				OnLeverDown.Invoke ();
				hasDownActivated = true;
			}
		}
		else if (ratio > 0.925f && leverRatio > 0.925f) {
			if (OnLeverUp != null && (allowMultipleUses || !hasUpActivated)) {
				OnLeverUp.Invoke ();
				hasUpActivated = true;
			}
		}
		leverRatio = ratio;
	}

}
