using UnityEngine;
using System.Collections;

public class rayCastManager : MonoBehaviour {
	public static Vector3 hitPoint, direction; //location of collision from the ray attached to main camera
	private int layerMask;

	void Start () {
		//rayCast will only hit with the Gaze Object layer
		layerMask = 1 << 12;
	}

	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, 100f, layerMask)) {
			hitPoint = hit.point;
			direction = transform.forward;
		}
	}
}
