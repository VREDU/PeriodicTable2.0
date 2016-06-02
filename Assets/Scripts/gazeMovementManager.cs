using UnityEngine;
using System.Collections;

public class gazeMovementManager : MonoBehaviour {
	public GameObject gazeObjectPrefab; //This object will collide with gazeRay for gameObjects to move towards
	private GameObject gazeObject;

	public void destroyGazeMode() {
		Destroy (GameObject.FindGameObjectWithTag ("gazeObject"));
	}

	public void createGazeObject() {
		gazeObject = GameObject.Instantiate(gazeObjectPrefab, gameObject.transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		gazeObject.transform.parent = gameObject.transform;
	}
}
