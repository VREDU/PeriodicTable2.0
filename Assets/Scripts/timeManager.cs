using UnityEngine;
using System.Collections;

public class timeManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
			GetComponent<TextMesh> ().text = canvasManager.timeLeft.ToString ("0");
	}
}