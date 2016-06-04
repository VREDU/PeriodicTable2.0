using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public GameObject atomPrefab;
	public int compoundLimit;
	private GameObject atom;
	private int compoundsFormed;
	private Transform objectTransform;
	private Vector3 offset;

	void Start () {
		objectTransform = GetComponent<Transform> ();
		offset = new Vector3 (0, 0, -1); //spawns atom in front of element
		compoundsFormed = 0;
	}
		
	public void selectElement() {
		canvasManager.shotsLeft--;
		//cant select elements when the round is over
		if (canvasManager.playing == false) {
			canvasManager.playing = true;
		}

		if (compoundLimit > compoundsFormed) {
			GameObject.FindGameObjectWithTag ("gazeObjectHolder").GetComponent<gazeMovementManager> ().createGazeObject ();
			atom = Instantiate (atomPrefab, objectTransform.position + offset, objectTransform.rotation) as GameObject;
			atom.transform.parent = gameObject.transform;
		}
	}


	public void SetGazedAt(bool gazedAt) {
		if (compoundsFormed < compoundLimit) {
			GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.white;
		} else {
			GetComponent<Renderer> ().material.color = Color.black;
		}
	}

	public void incrementCompounds() {
		compoundsFormed = ++compoundsFormed;
	}
}
