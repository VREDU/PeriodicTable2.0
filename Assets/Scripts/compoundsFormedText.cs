using UnityEngine;
using System.Collections;

public class compoundsFormedText : MonoBehaviour {

	public GameObject canvasObject;
	private canvasManager canvas;
	private int compoundGoal, compoundsLeft;

	void Start() {
		canvas = canvasObject.GetComponent<canvasManager> ();
		compoundGoal = canvas.getCompoundGoal ();
	}

	void Update () {
		compoundsLeft = compoundGoal - canvasManager.compoundsFormed;
		GetComponent<TextMesh> ().text = compoundsLeft + "\ndiatomic moleculues\n left to form";
	}
}
