using UnityEngine;
using System.Collections;

public class raycastTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit))
			Debug.Log (hit.point);
	}
}
