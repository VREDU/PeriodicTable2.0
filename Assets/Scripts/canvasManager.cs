using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public GameObject congrats;
	public static bool gameOver;
	public static int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (score>2) {
			congrats.SetActive (true);
			score = 0;
		}
	}

	public void playAgain() {
		gameOver = false;
		SceneManager.LoadScene(0);
	}
}
