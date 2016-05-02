using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	public static Vector3 hitPoint; //location of collision from the ray attached to main camera
	public static bool gazeMovement;

	void Start () {
		gazeMovement = true;
	}

	void Update () {
		RaycastHit hit;
		Physics.Raycast (transform.position, transform.forward, out hit);
		hitPoint = hit.point;
		//Debug.Log (gazeMovementManager.hitPoint);
	}

	public void switchGazeMode() {
		gazeMovement = !gazeMovement;
	}
}
