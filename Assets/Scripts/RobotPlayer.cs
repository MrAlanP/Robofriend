using UnityEngine;
using System.Collections;

public class RobotPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Placeholder teleport function to move the VR player
	/// </summary>
	/// <param name="teleportPoint">Teleport point.</param>
	public void Teleport(Vector3 teleportPoint){
		transform.position = teleportPoint;

	}
}
