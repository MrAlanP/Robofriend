using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public RobotPlayer robotPlayer;
	public HumanPlayer humanPlayer;

	public Transform[] puzzleStartLocations;

	private int currentPuzzleIndex = 0;

	void Awake() {
		if (instance == null) {
			instance = this;
		} 
		else {
			Destroy (gameObject);
			return;
		}
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void StartPuzzle () {
		robotPlayer.Teleport (puzzleStartLocations [currentPuzzleIndex].position);
	}

	public void CompletePuzzle(){
		currentPuzzleIndex++;
		StartPuzzle ();
	}
}
