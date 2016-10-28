using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SiloDoors : MonoBehaviour {

	public GameObject leftDoor, rightDoor;

	float openSpeed = 1.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OpenDoors(){
		//-11 left door, 11 right door
		leftDoor.transform.DOLocalMoveX(-11.0f, openSpeed);
		rightDoor.transform.DOLocalMoveX(11.0f, openSpeed);
	}
	public void CloseDoors(){
		//-11 left door, 11 right door
		leftDoor.transform.DOLocalMoveX(0.0f, openSpeed);
		rightDoor.transform.DOLocalMoveX(0.0f, openSpeed);
	}
}
