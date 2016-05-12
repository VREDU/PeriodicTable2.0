using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	
	public GameObject craftingPlanePrefab;

	void Start () {
	}

	void Update () {
	}
	//need to change how this is being done
	public void destroyGazeMode() {
		Destroy (GameObject.FindGameObjectWithTag ("gazePlane"));
	}

	public void createGazePlane() {
		//Instantiate (craftingPlanePrefab, new Vector3 (-1.31f, 0, 5), Quaternion.Euler (90, 0, 0));
		Instantiate (craftingPlanePrefab, new Vector3 (0, 0, 0), Quaternion.Euler (0, 0, 0));
	}
}
