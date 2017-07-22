using UnityEngine;
using System.Collections;

public class HandPicker : MonoBehaviour {

	void Update () {
		GetComponent<SphereCollider>().enabled = Input.GetKey(KeyCode.LeftShift);
		if (transform.childCount > 0 && (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetMouseButton(0))) {
			GameObject child = transform.GetChild(0).gameObject;
			child.transform.SetParent(transform.parent);
			child.GetComponent<CapsuleCollider>().enabled = true;
		}
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(-5.0f * Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(5.0f * Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(0.0f, 0.0f, -5.0f * Time.deltaTime);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Translate(0.0f, 0.0f, 5.0f * Time.deltaTime);
		if (Input.GetKey(KeyCode.End))
			transform.Translate(0.0f, -5.0f * Time.deltaTime, 0.0f);
		if (Input.GetKey(KeyCode.PageDown))
			transform.Translate(0.0f, 5.0f * Time.deltaTime, 0.0f);
	}
}
