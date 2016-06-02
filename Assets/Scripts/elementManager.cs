using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public GameObject atomPrefab;
	private GameObject atom;
	private Transform element;
	private Vector3 offset;
	public int compoundLimit;
	private int compoundsFormed;

	void Start () {
		element = GetComponent<Transform> ();
		offset = new Vector3 (0, 0, -1); //spawns atom in front of element
		compoundsFormed = 0;
	}
		
	void Update () {
		Debug.Log (compoundsFormed);
	}

	public void SetGazedAt(bool gazedAt) {
		if (compoundsFormed < compoundLimit) {
			GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
		} else {
			GetComponent<Renderer> ().material.color = Color.black;
		}
	}

	public void selectElement() {

		if (canvasManager.playing == false) {
			canvasManager.playing = true;
		}

		if (compoundLimit > compoundsFormed) {
			GameObject.FindGameObjectWithTag ("gazeObjectHolder").GetComponent<gazeMovementManager> ().createGazeObject ();
			atom = Instantiate (atomPrefab, element.position + offset, element.rotation) as GameObject;
			atom.transform.parent = gameObject.transform;
		}
	}

	public void incrementCompounds() {
		compoundsFormed = ++compoundsFormed;
	}
}
