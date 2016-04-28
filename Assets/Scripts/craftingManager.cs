using UnityEngine;
using System.Collections;

public class craftingManager : MonoBehaviour {
	public GameObject craftingPlanePrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void createGazePlane() {
		Instantiate (craftingPlanePrefab, new Vector3 (0, 0, 4.8f), Quaternion.Euler (90, 0, 0));
	}
}
