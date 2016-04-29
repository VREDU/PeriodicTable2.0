using UnityEngine;
using System.Collections;

public class landingManager : MonoBehaviour {
	public GameObject landingPoint; //point for object to move towards
	public float speed; //speed object approaches landing point
	private Collider atom; //game object that enters collider
	private float step; //function of speed and time
	private bool enter; //flag if object enters collider
	void Start () {
		enter = false;
	}

	void Update () {
		//not sure if update is the best way to do this??
		step = speed * Time.deltaTime;
		if (enter == true) {
			atom.transform.position = Vector3.MoveTowards (atom.transform.position, landingPoint.transform.position, step);
		}
	}

	void OnTriggerEnter (Collider other) {
		gazeMovementManager.gazeMovement = false;
		elementManager.atomSelected = false;
		Destroy(GameObject.FindGameObjectWithTag ("craftingPlane"));
		atom = other;
		enter = true;
	}
}
