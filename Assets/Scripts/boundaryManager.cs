using UnityEngine;
using System.Collections;

public class boundaryManager : MonoBehaviour {

	//users score doesn't increase if an atom bounces off a wall then forms a compound
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "shooter") {
			Debug.Log ("collision");
			other.gameObject.GetComponent<shooterManager> ().setShooter (false);
		}
	}
}

