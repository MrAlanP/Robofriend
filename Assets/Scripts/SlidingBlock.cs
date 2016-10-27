﻿using UnityEngine;
using System.Collections;
using VRTK;

public class SlidingBlock : MonoBehaviour {

	public VRTK_InteractableObject handleInteractable;
	public Rigidbody blockBody;


	// Use this for initialization
	void Start () {
		handleInteractable.InteractableObjectGrabbed += new InteractableObjectEventHandler (OnHandleGrab);
		handleInteractable.InteractableObjectUngrabbed += new InteractableObjectEventHandler (OnHandleRelease);
	
		LockBLock ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnHandleGrab(object sender, InteractableObjectEventArgs e){
		UnlockBlock ();

	}

	void OnHandleRelease(object sender, InteractableObjectEventArgs e){
		LockBLock ();
	}

	void LockBLock(){
		blockBody.constraints = RigidbodyConstraints.FreezeAll;
	}

	void UnlockBlock(){
		blockBody.constraints = RigidbodyConstraints.None;
	}
}