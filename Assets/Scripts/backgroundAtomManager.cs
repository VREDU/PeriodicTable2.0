using UnityEngine;
using System.Collections;

public class backgroundAtomManager : MonoBehaviour {
	private Vector3 force;
	private int x,y,z; 

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody> ().AddForce (randomVector(), ForceMode.Impulse);
		gameObject.GetComponent<Rigidbody> ().AddTorque (randomVector ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector3 randomVector(){
		x = Random.Range (-3, 3);
		y = Random.Range (-3, 3);
		z = Random.Range (-3, 3);
		return new Vector3 (x, y, z);
	}
}
