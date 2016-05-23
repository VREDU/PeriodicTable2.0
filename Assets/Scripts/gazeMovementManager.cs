using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	
	public GameObject gazeObjectPrefab;
	private GameObject gazeObject;

	void Start () {
	}

	void Update () {
	}

	public void destroyGazeMode() {
		Destroy (GameObject.FindGameObjectWithTag ("gazeObject"));
	}

	public void createGazeObject() {
		gazeObject = GameObject.Instantiate(gazeObjectPrefab, gameObject.transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		gazeObject.transform.parent = gameObject.transform;
	}
}
