using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	public static Vector3 hitPoint; //location of collision from the ray attached to main camera
	public static bool gazeMovement; //flag for objects controlled by users gaze

	void Start () {
		gazeMovement = false;
	}

	void Update () {
		RaycastHit hit;
		if (gazeMovement==true) {
			Physics.Raycast (transform.position, transform.forward, out hit);
			hitPoint = hit.point; 
		}
	}
}
