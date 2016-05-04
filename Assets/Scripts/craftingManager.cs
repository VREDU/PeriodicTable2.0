using UnityEngine;
using System.Collections;

public class craftingManager : MonoBehaviour {
	public GameObject craftingPlanePrefab;
	// Use this for initialization
	void Start () {
	
	}

	void Update () {
	}

	public void createGazePlane() {
		Instantiate (craftingPlanePrefab, new Vector3 (-1, 0, 5), Quaternion.Euler (90, 0, 0));
	}
}
