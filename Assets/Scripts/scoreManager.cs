using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {

	private canvasManager canvas;
	private int compoundGoal, compoundsLeft;

	void Start() {
		canvas = transform.parent.GetComponent<canvasManager> ();
		compoundGoal = canvas.getCompoundGoal ();
	}

	void Update () {
		compoundsLeft = compoundGoal - canvasManager.compoundsFormed;
		GetComponent<TextMesh> ().text = compoundsLeft + "\ndiatomic moleculues\n left to form";
	}
}
