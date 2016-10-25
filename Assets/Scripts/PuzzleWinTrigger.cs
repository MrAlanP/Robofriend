using UnityEngine;
using System.Collections;

public class PuzzleWinTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.GetComponent<HumanPlayer> ()) {
			GameManager.instance.CompletePuzzle ();
		}

	}
}
