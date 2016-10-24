using UnityEngine;
using System.Collections;
using VRTK;

public class Player : MonoBehaviour {

	private VRTK_InteractableObject interactableObject;
	private SuperCharacterController characterController;

	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		interactableObject = GetComponent<VRTK_InteractableObject> ();
		interactableObject.InteractableObjectGrabbed += new InteractableObjectEventHandler (OnGrab);
		interactableObject.InteractableObjectUngrabbed += new InteractableObjectEventHandler (OnRelease);

		characterController = GetComponent<SuperCharacterController> ();
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGrab(object sender, InteractableObjectEventArgs e){
		characterController.enabled = false;
		rigidbody.isKinematic = false;
		interactableObject.previousKinematicState = rigidbody.isKinematic;
	}

	void OnRelease(object sender, InteractableObjectEventArgs e){

	}

	void OnCollisionEnter(Collision col){

	}

}
