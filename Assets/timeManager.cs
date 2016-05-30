using UnityEngine;
using System.Collections;

public class timeManager : MonoBehaviour {
	public static float timeLeft;
	public static bool gameOver;
	// Use this for initialization
	void Start () {
		timeLeft = 60.0f;
		gameOver = false;
	}

	// Update is called once per frame
	void Update () {
		if (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			GetComponent<TextMesh> ().text = timeLeft.ToString ("0");
		}

		if (timeLeft <= 0) {
			gameOver = true;
		}

	}
}