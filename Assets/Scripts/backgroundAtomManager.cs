using UnityEngine;
using System.Collections;

public class backgroundAtomManager : MonoBehaviour {
	private Vector3 force;
	private int x,y,z; 

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody> ().AddForce (randomVector(), ForceMode.Impulse);
		Random.Range (-1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector3 randomVector(){
		x = Random.Range (-1, 1);
		y = Random.Range (-1, 1);
		z = Random.Range (-1, 1);
		return new Vector3 (x, y, z);
	}
}
