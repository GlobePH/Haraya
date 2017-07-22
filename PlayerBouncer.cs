using UnityEngine;
using System.Collections;

public class PlayerBouncer : MonoBehaviour {

	GameObject maincamera;
	GameObject head;

	float stp = 0.0f;

	void Start() {
		QualitySettings.antiAliasing = 4;
		maincamera = transform.GetChild(0).GetChild(0).gameObject;
		head = transform.GetChild(0).gameObject;
		Input.gyro.enabled = true;
	}

	void Update() {

		if (stp <= 0.0f) {                                          //try up down, limit time 
			if (Vector3.Magnitude(Input.gyro.rotationRate) < 0.5f || Input.GetKeyDown(KeyCode.Space))  //0.5
				if (Vector3.Magnitude(Input.acceleration) > 1.1f || Input.GetKey(KeyCode.Space))   //1.1
					//if (stp <= 0.0f)
						stp = 1.0f;
		} else {
			//float spd = 3.5f;   //step/second	//2.5//3.0
			//float pce = 1.5f;   //units/step	//1.0
			float spd = 4.0f;   //step/second	//2.5//3.0
			float pce = 2.0f;   //units/step	//1.0
			float dir = maincamera.transform.rotation.eulerAngles.y * Mathf.Deg2Rad;
			float dst = pce * spd * Time.deltaTime;
			transform.Translate(dst * Mathf.Sin(dir), 0, dst * Mathf.Cos(dir), Space.World);
			stp -= spd * Time.deltaTime;
			head.transform.localPosition = new Vector3(0.0f, -0.25f * Mathf.Sin(stp * 2.0f * Mathf.PI), 0.0f);
			//transform.Translate(0.0f, 0.025f * Mathf.Sin(stp * 2.0f * Mathf.PI), 0.0f);
		}

	}

}
