using UnityEngine;
using System.Collections;

public class atomTitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = atom.transform.position.normalized;
		transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
		//transform.position = transform.position + Camera.main.transform.position.normalized * -1;
	}
}
