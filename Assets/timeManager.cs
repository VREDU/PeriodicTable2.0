using UnityEngine;
using System.Collections;

public class timeManager : MonoBehaviour {
	public static bool gameOver;
	// Use this for initialization
	void Start () {
		gameOver = false;
	}

	// Update is called once per frame
	void Update () {
			GetComponent<TextMesh> ().text = canvasManager.timeLeft.ToString ("0");
	}
}