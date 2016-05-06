using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	public static Vector3 hitPoint; //location of collision from the ray attached to main camera
	public static bool gazeMovement;
	public GameObject craftingPlanePrefab;
	private int layerMask;

	void Start () {
		layerMask = 1 << 12;
	}

	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, 100f, layerMask)) {
			hitPoint = hit.point;
		}
	}

	public void destroyGazeMode() {
			Destroy (GameObject.FindGameObjectWithTag ("craftingPlane"));
	}

	public void createGazePlane() {
		Instantiate (craftingPlanePrefab, new Vector3 (-1, 0, 5), Quaternion.Euler (90, 0, 0));
	}
}
