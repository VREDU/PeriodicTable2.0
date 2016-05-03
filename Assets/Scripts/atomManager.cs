using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float speed; //speed object approaches gaze
	private float step;
	private bool moveControl, test1;
	public bool stable;
	private Vector3 hitPoint;

	void Start () {
		moveControl = true;
		step = speed * Time.deltaTime;
	}

	void Update () {
		//Debug.Log ("test1:" + test1);
		//Debug.Log ("moveControl:" + moveControl);

		if (gazeMovementManager.gazeMovement == true && moveControl == true) {
			transform.position = Vector3.MoveTowards (transform.position, gazeMovementManager.hitPoint, step);
		}

		/*if (test1==true) {
			transform.position = Vector3.MoveTowards (transform.position, gazeMovementManager.hitPoint, step);
		}*/

		if (gazeMovementManager.gazeMovement == false && stable == false) {
			Destroy (gameObject);
			Destroy(GameObject.FindGameObjectWithTag ("craftingPlane"));
		}
	}

	public void switchGazeMode() {
		gazeMovementManager.gazeMovement = !gazeMovementManager.gazeMovement;
		changeStable (!stable);
	}

	public void changeStable(bool isStable) {
		stable = isStable;
	}

	public void moveMode(bool enabled) {
		moveControl = enabled;
	}
		
	public void OnCollisionEnter(Collision c) {
		if (c.rigidbody != null) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			moveControl = false;
			test1 = true;
		}
	}

	public bool getTest1() {
		return test1;
	}
}
