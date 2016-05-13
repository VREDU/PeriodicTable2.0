using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	
	public GameObject gazeObjectPrefab;
	private GameObject gazeObject;

	void Start () {
	}

	void Update () {
	}
	//need to change how this is being done
	public void destroyGazeMode() {
		Destroy (GameObject.FindGameObjectWithTag ("gazePlane"));
	}

	public void createGazeObject() {
		gazeObject = GameObject.Instantiate(gazeObjectPrefab, gameObject.transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		gazeObject.transform.parent = gameObject.transform;
	}
}
