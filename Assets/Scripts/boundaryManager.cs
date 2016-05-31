using UnityEngine;
using System.Collections;

public class boundaryManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//users score doesn't increase if an atom bouncey off a wall then forms a compound
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "shooter") {
			other.gameObject.GetComponent<shooterManager> ().setShooter (false);
		}
	}
}

