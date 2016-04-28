using UnityEngine;
using System.Collections;

public class landingManager : MonoBehaviour {
	public GameObject landingPoint;
	public float speed;
	private Collider atom;
	private float step;
	private bool trigger;
	void Start () {
		trigger = false;
	}

	void Update () {
		step = speed * Time.deltaTime;
		if (trigger == true) {
			atom.transform.position = Vector3.MoveTowards (atom.transform.position, landingPoint.transform.position, step);
		}
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log (other.gameObject.name);
		raycastTest.gazeMovement = false;
		atom = other;
		trigger = true;
	}
}
