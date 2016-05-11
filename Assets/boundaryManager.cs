using UnityEngine;
using System.Collections;

public class boundaryManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other) {
		Debug.Log ("Collision");
		if (other.gameObject.GetComponent<atomManager> ().isShooter ()) {
			Destroy (other.gameObject);
			elementManager.selectedElement.GetComponent<elementManager> ().reload ();
		}
	}
}
