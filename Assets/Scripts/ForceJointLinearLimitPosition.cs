using UnityEngine;
using System;
using System.Collections;

public class ForceJointLinearLimitPosition : MonoBehaviour {
	[Tooltip("Ratio of the linear limit position to use. Between -1 and 1.")]
	public float ratio = 0.0f;

	ConfigurableJoint joint;

	bool prevKinematicValue = false;

	bool hasUpdatedKinematic = false;
	// Use this for initialization
	void Awake () {
		joint = GetComponent<ConfigurableJoint> ();
		GameObject connectedGameObject = joint.connectedBody.gameObject;

		prevKinematicValue = joint.connectedBody.isKinematic;
		joint.connectedBody.isKinematic = true;

		float offset = joint.linearLimit.limit * ratio;
		float xOffset = offset * Convert.ToInt32(joint.xMotion == ConfigurableJointMotion.Limited);
		float yOffset = offset * Convert.ToInt32(joint.yMotion == ConfigurableJointMotion.Limited);
		float zOffset = offset * Convert.ToInt32(joint.zMotion == ConfigurableJointMotion.Limited);		
		connectedGameObject.transform.localPosition = new Vector3 (connectedGameObject.transform.localPosition.x + xOffset, connectedGameObject.transform.localPosition.y + yOffset, connectedGameObject.transform.localPosition.z + zOffset);


	}

	void Update(){
		if (!hasUpdatedKinematic) {
			hasUpdatedKinematic = true;
			joint.connectedBody.isKinematic = false;
		}

	}
}
