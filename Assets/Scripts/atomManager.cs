using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float speed; //speed object approaches gaze
	private float step;
	private bool moveControl;
	public bool stable;
	private Vector3 hitPoint;

	void Start () {
		moveControl = true;
		step = speed * Time.deltaTime;
	}

	void Update () {
		Debug.Log ("GazeMovement:" + gazeMovementManager.gazeMovement);
		Debug.Log ("stable:" + stable);

		if (gazeMovementManager.gazeMovement==true && moveControl== true) {
			transform.position = Vector3.MoveTowards (transform.position, gazeMovementManager.hitPoint, step);
		}

		if (gazeMovementManager.gazeMovement==false && stable == false) {
			Debug.Log ("destroy");
			Destroy (gameObject);
			Destroy(GameObject.FindGameObjectWithTag ("craftingPlane"));
		}
	}

	public void switchGazeMode() {
		gazeMovementManager.gazeMovement = !gazeMovementManager.gazeMovement;
		stable = !stable;
	}

	public void moveMode(bool enabled) {
		moveControl = enabled;
	}
}
