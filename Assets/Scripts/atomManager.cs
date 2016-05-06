using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float speed; //speed object approaches gaze
	private float step;
	private bool moveControl, compound;
	public bool stable;
	private Vector3 hitPoint;

	void Start () {
		moveControl = true;
		step = speed * Time.deltaTime;
	}

	void Update () {
		Debug.Log ("Stable:" + stable);
		Debug.Log ("Move Control:" + moveControl);

		if (moveControl == true) {
			transform.position = Vector3.MoveTowards (transform.position, gazeMovementManager.hitPoint, step);
		}

		if (stable == false && moveControl == false) {
			Destroy (gameObject);
		}

		if (GameObject.FindWithTag ("craftingPlane") == null) {
			if (moveControl == true) {
				gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(1,10), Random.Range(1,10), Random.Range(1,10), ForceMode.Impulse);
				moveControl = false;
			}
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
		if (c.rigidbody != null && compound == false) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			moveControl = false;
			compound = true;
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(1,10), Random.Range(1,10), Random.Range(1,10), ForceMode.Impulse);
		}
	}

	public bool isCompound() {
		return compound;
	}
}
