using UnityEngine;
using System.Collections;

public class raycastTest : MonoBehaviour {
	public static Vector3 hitPoint;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit)){
			hitPoint = hit.point;
			//test.transform.position = Vector3.MoveTowards (test.transform.position, hit.point, step);
		}
	}
}
