using UnityEngine;
using System.Collections;

public class backgroundAtomManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5), ForceMode.Impulse);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
