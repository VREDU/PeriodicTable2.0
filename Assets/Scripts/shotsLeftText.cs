using UnityEngine;
using System.Collections;

public class shotsLeftText : MonoBehaviour {

	void Update () {
		GetComponent<TextMesh> ().text = canvasManager.shotsLeft.ToString ("0") +"\nshots left";
	}
}
