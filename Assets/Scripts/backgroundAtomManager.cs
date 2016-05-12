using UnityEngine;
using System.Collections;

public class backgroundAtomManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-2,2), Random.Range(-2,2), Random.Range(-2,2), ForceMode.Impulse);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
