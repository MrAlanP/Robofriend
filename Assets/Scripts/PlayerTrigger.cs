using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {

	public UnityEvent TriggerEnter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			TriggerEnter.Invoke ();
		}
	}
}
