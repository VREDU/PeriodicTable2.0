using UnityEngine;
using System.Collections;

public class rayCastManager : MonoBehaviour {
	public static Vector3 hitPoint, direction; //location of collision from the ray attached to main camera
	private int layerMask;

	// Use this for initialization
	void Start () {
		layerMask = 1 << 12;
	}
	
	// Update is called once per frame
	void Update () {
		//Cursor.visible = false;
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, 100f, layerMask)) {
			hitPoint = hit.point;
			direction = transform.forward;
		}
	}
}
