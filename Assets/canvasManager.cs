using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public GameObject congrats;
	public static bool gameOver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Game Over:" + gameOver);
		if (gameOver) {
			congrats.SetActive (true);
		}
	}

	public void playAgain() {
		gameOver = false;
		SceneManager.LoadScene(0);
	}
}
