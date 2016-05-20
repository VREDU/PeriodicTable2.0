using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public string elementName;
	public GameObject atomPrefab, atomSpawn;
	private Transform element;
	private Vector3 offset;

	void Start () {
		element = GetComponent<Transform> ();
		offset = new Vector3 (0, 0, -1);
	}
		
	void Update () {
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.white;
	}

	public void selectElement() {
			GameObject.FindGameObjectWithTag ("gazePlaneHolder").GetComponent<gazeMovementManager> ().createGazeObject ();
			Instantiate (atomPrefab, element.position + offset, element.rotation);
	}

	public void reload() {
		GameObject.FindGameObjectWithTag ("gazePlaneHolder").GetComponent<gazeMovementManager> ().createGazeObject ();
		Instantiate (atomPrefab, element.position + offset, element.rotation);
	}
}
