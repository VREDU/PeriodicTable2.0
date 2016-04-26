using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float step, speed;
	public GameObject landingZonge;

	void Start () {
	}

	void Update () {
		speed = 1.0f;
		step = speed * Time.deltaTime;
		if(raycastTest.gazeMovement==true) {
			Debug.Log (raycastTest.hitPoint);
			transform.position = Vector3.MoveTowards (transform.position, raycastTest.hitPoint, step);
		}
	}

	/*void onTriggerStay (Collider other) {
		atom.inLandingZone = true;
	}*/
}
