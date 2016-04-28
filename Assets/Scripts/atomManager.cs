using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float speed; //speed object approaches gaze
	private float step;

	void Start () {
	}

	void Update () {
		step = speed * Time.deltaTime;
		if(gazeMovementManager.gazeMovement==true) {
			transform.position = Vector3.MoveTowards (transform.position, gazeMovementManager.hitPoint, step);
		}
	}
}
