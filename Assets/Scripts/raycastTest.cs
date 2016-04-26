using UnityEngine;
using System.Collections;

public class raycastTest : MonoBehaviour {
	public static Vector3 hitPoint;
	public static bool gazeMovement;
	public float speed;

	void Start () {
		gazeMovement = false;
	}
		
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit)){
			hitPoint = hit.point;
		}
	}
}
