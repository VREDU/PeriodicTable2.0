using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float step, speed;

	void Start () {
	}

	void Update () {
		speed = 1.0f;
		step = speed * Time.deltaTime;
		if(raycastTest.gazeMovement==true) {
			transform.position = Vector3.MoveTowards (transform.position, raycastTest.hitPoint, step);
		}
	}

	void OnTriggerEnter (Collider other) {
		//Debug.Log ("On Trigger Enter (atom)");
		//raycastTest.gazeMovement = false;
		//transform.position
	}
}
