using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public GameObject atomPrefab, atoms_boundary;
	public string elementName;
	private Transform element;
	private Vector3 offset;

	void Start () {
		element = GetComponent<Transform> ();
		offset = new Vector3 (0, 0, -1); //spawns atom in front of element
	}
		
	void Update () {
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
	}

	public void selectElement() {

		if (canvasManager.playing == false) {
			canvasManager.playing = true;
		}
			GameObject.FindGameObjectWithTag ("gazeObjectHolder").GetComponent<gazeMovementManager> ().createGazeObject ();
			Instantiate (atomPrefab, element.position + offset, element.rotation);
	}
}
