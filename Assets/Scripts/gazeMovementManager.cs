using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	public static Vector3 hitPoint; //location of collision from the ray attached to main camera
	public static bool gazeMovement;
	public GameObject craftingPlanePrefab;
	private int layerMask;

	void Start () {
		gazeMovement = true;
		layerMask = 1 << 12;
	}

	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, layerMask)) {
			hitPoint = hit.point;
		}
	}

	public void switchGazeMode() {
		gazeMovement = !gazeMovement;
	}

	public void createGazePlane() {
		Instantiate (craftingPlanePrefab, new Vector3 (-1, 0, 5), Quaternion.Euler (90, 0, 0));
	}
}
