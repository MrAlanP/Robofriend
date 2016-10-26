using UnityEngine;
using System.Collections;
using VRTK;

public class RobotPlayer : MonoBehaviour {

	public Light headLight;

	public VRTK_ControllerEvents leftControllerEvents, rightControllerEvents;

	// Use this for initialization
	void Start () {
		leftControllerEvents.TouchpadPressed += new ControllerInteractionEventHandler(DoTouchpadClicked);
		rightControllerEvents.TouchpadPressed += new ControllerInteractionEventHandler(DoTouchpadClicked);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug key
		if (Input.GetKeyDown (KeyCode.Q)) {
			ToggleHeadLight ();
		}
	}

	private void DoTouchpadClicked(object sender, ControllerInteractionEventArgs e)
	{
		ToggleHeadLight ();
	}

	/// <summary>
	/// Placeholder teleport function to move the VR player
	/// </summary>
	/// <param name="teleportPoint">Teleport point.</param>
	public void Teleport(Vector3 teleportPoint){
		transform.position = teleportPoint;

	}

	void ToggleHeadLight(){
		headLight.enabled = !headLight.enabled;
	}

}
