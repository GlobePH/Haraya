using UnityEngine;
using System.Collections;

public class PlaceTarget : MonoBehaviour {

	public bool flip = false;

	void OnTriggerEnter(Collider that) {
		if (name == that.name) {
			GetComponent<MeshRenderer>().enabled = false;
			that.transform.SetParent(transform.parent);
			that.transform.localPosition = transform.localPosition;
			that.transform.localRotation = transform.localRotation;
			if (flip)
				that.transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
			//that.GetComponent<CapsuleCollider>().enabled = false;
		}
	}

	void OnTriggerExit(Collider that) {
		if (name == that.name||that.name=="Hand") {
			GetComponent<MeshRenderer>().enabled = true;
		}
	}

}
