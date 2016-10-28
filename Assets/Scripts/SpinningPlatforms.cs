using UnityEngine;
using System.Collections;

public class SpinningPlatforms : MonoBehaviour {

	public float spinSpeed = 10.0f;

	float spinSpeedRatio = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, spinSpeed, 0) * spinSpeedRatio * Time.deltaTime);
	}

	public void SetSpinSpeedRatio(float ratio){
		spinSpeedRatio = ratio;
	}
}
