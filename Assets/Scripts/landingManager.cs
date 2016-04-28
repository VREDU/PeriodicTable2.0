using UnityEngine;
using System.Collections;

public class landingManager : MonoBehaviour {
	public GameObject landingPoint;
	public Collider atom;
	public float speed;
	private float step;
	public bool trigger;
	void Start () {
		trigger = false;
	}
	
	// Update is called once per frame
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
