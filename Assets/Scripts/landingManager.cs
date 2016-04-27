using UnityEngine;
using System.Collections;

public class landingManager : MonoBehaviour {
	public GameObject landingPoint;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		Debug.Log (other.gameObject.name);
		raycastTest.gazeMovement = false;
		other.gameObject.transform.position = landingPoint.transform.position;
	}
}
