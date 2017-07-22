using UnityEngine;
using System.Collections;

public class PickableObject : MonoBehaviour {

	void OnTriggerEnter(Collider that) {
		if (that.name == "Hand") {
			if (that.transform.childCount == 0) {
				transform.SetParent(that.gameObject.transform);
				GetComponent<CapsuleCollider>().enabled = false;
			}
		}
	}

}
